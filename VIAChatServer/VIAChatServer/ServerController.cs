using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using VIAChatServer.Models;

namespace VIAChatServer
{
    class Server
    {
        private Monitor monitor;
        private TcpListener listener;
        private ArrayList clients;
        private static ArrayList onlineUsers;
        private ServiceHost host;
        private Uri serviceUrl;
        public bool IsRunning { get; private set; }
        private Thread connectionsService;
        public int Port { get; set; }

        public Server(Monitor monitor)
        {
            this.monitor = monitor;
            clients = new ArrayList();
            onlineUsers = new ArrayList();
            IsRunning = false;
        }

        public void Start()
        {
            /*
             * Actual TCP server
             */
            byte[] adr = { 127, 0, 0, 1 };
            IPAddress ipAdr = new IPAddress(adr);
            listener = new TcpListener(ipAdr, Port);
            listener.Start();
            IsRunning = true;

            /*
             * Incoming connections thread
             */
            connectionsService = new Thread(new ThreadStart(waitForConnections));
            connectionsService.IsBackground = true;
            connectionsService.Start();

            /*
             * Web service (for online users count)
             */
            serviceUrl = new Uri("http://localhost:8080/users");
            host = new ServiceHost(typeof(OnlineUsersService), serviceUrl);
            //host.Open();
            Console.WriteLine("The service is ready at http://localhost:8080/users");
            Console.WriteLine("You can get the number of online users at: http://localhost:8080/users/online");
        }

        public void Stop()
        {
            if (IsRunning)
            {
                IsRunning = false;
                listener.Stop();
                host.Close();
                onlineUsers.Clear();
                monitor.ResetOnlineUsers();
            }
        }

        private void waitForConnections()
        {
            try
            {
                while (IsRunning) //The thread has to be stopped from the inside, to prevent deadlocks
                {
                    TcpClient client = listener.AcceptTcpClient(); //Wait for an incoming connection
                    clients.Add(client);
                    Thread socket = new Thread(() => SocketThread(client.GetStream())); //Creates thread and pass stream parameter to the method being threaded
                    socket.IsBackground = true;
                    socket.Start();
                }
            }
            catch(SocketException e)
            {
                Console.WriteLine(e);
            }
        }

        private void SocketThread(NetworkStream stream) //method being threaded, handles the socket communication
        {

            User user = KnockKnock(stream); //Open the door ...

            if (user == null) //It was just wind :/
                return;

            else if(user.toBeRegistered) //Oh, a new face !
            {

                bool registered = RegisterUser(user, stream);
                if (!registered) //I don't like you
                    return;
                else
                {
                    monitor.Notify(user.username + " has registered."); //Welcome to my house !
                }

            } else { //Your face rings a bell ...

                bool authenticated = AuthenticateUser(user, stream); //Okay let me put on my glasses

                if (authenticated) //Oh it's you ! It's been a while !
                {
                    onlineUsers.Add(user);
                    monitor.AddUser(user);
                    monitor.Notify(user.username + " is connected.");
                    //SendMessageHistory(stream); //Here is what you missed
                } else
                    return;

            }


            while (IsRunning) //The communication is up until the client disconnects
            {
                int recv;
                byte[] data = new byte[1024];
                try
                {
                    recv = stream.Read(data, 0, data.Length);
                }
                catch (IOException)
                {
                    break;
                }

                if (recv == 0)
                    break;


                XmlSerializer serializer = new XmlSerializer(typeof(Message));
                Message msg;

                using (MemoryStream ms = new MemoryStream(data))
                {
                    msg = (Message)serializer.Deserialize(ms);
                }

                SaveMessage(msg, user);
                monitor.UserSays(user, msg);
            }

            monitor.Notify(user.username + " is disconnected.");
            monitor.RemoveUser(user);
        }


        /*
         * Handles the first action received from the client.
         * Could be registration or login request.
         * Returns true if the user is authenticated/registered
         */
        private User KnockKnock(NetworkStream stream)
        {
            int recv = 0;
            byte[] data = new byte[1024];
            User user = null;

            while (recv == 0)
            {
                try
                {
                    recv = stream.Read(data, 0, data.Length);
                }
                catch (IOException)
                {
                    Console.WriteLine("TCP error");
                }
            }

            XmlSerializer serializer = new XmlSerializer(typeof(User));

            using (MemoryStream ms = new MemoryStream(data))
            {
                user = (User) serializer.Deserialize(ms);
            }

            return user;
        }


        /*
         * Saves a message in the database
         */
        private bool SaveMessage(Message msg, User user)
        {
            bool success = true;
            using (ViaChatEntities db = new ViaChatEntities())
            {
                msg.User = user;
                db.Messages.Add(msg);
                try
                {
                    db.SaveChanges();
                }
                catch(Exception e)
                {
                    success = false;
                    Console.WriteLine(e);
                }
            }

            return success;
        }

        /*
         * Registers a user in the database
         * Returns true if success
         */
        private bool RegisterUser(User user, NetworkStream stream)
        {
            bool success = true;
            using (ViaChatEntities db = new ViaChatEntities())
            {
                db.Users.Add(user);
                try
                {
                    db.SaveChanges();
                    SendResponse(true, "", stream);
                }
                catch(Exception e)
                {
                    success = false;
                    SendResponse(false, e.ToString(), stream);
                    Console.WriteLine(e);
                }
            }

            return success;
        }


        /*
         * Authenticates a user by checking if there is a record in the DB
         * where the useranme and password match
         */
        private bool AuthenticateUser(User user, NetworkStream stream)
        {
            bool auth = false;
            using (ViaChatEntities db = new ViaChatEntities())
            {
                var query = from u in db.Users
                            where u.username == user.username
                                  && u.password == user.password
                            select u;

                if (query.FirstOrDefault<User>() != null)
                {
                    auth = true;
                    SendResponse(true, "", stream);
                }
                else
                {
                    SendResponse(false, "No user found with those credentials.", stream);
                }
            }

            return auth;
        }

        private void SendResponse(bool success, String body, NetworkStream stream)
        {
            Response response = new Response(success, body);
            XmlSerializer serializer = new XmlSerializer(typeof(Response));
            MemoryStream memoryStream = new MemoryStream();

            using (StreamWriter writer = new StreamWriter(memoryStream, Encoding.UTF8))
            {
                serializer.Serialize(writer, response);
                byte[] utf8EncodedXml = memoryStream.ToArray();
                stream.Write(utf8EncodedXml, 0, utf8EncodedXml.Length);
            }
        }

        private User FindUser(string username)
        {
            /*
             * Returns the user having the corresponding username
            */
            using (ViaChatEntities context = new ViaChatEntities())
            {
                var query =  from u in context.Users
                               where u.username == username
                               select u;

                return query.FirstOrDefault<User>();
            }
        }

        private void SendMessageHistory(NetworkStream stream)
        {
            ViaChatEntities context = new ViaChatEntities();

            foreach(Message message in context.Messages)
            {
                stream.Write(Encoding.ASCII.GetBytes(message.body), 0, message.body.Length); //Writes the message body in the stream
            }
        }

        public static int NbOnlineUsers()
        {
            return onlineUsers.Count;
        }
    }
}
