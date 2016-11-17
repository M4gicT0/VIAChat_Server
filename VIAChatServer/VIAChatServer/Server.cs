using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace VIAChatServer
{
    class Server
    {
        private Monitor monitor;
        private TcpListener listener;
        private ArrayList clients;
        public bool IsRunning { get; private set; }
        private Thread connectionsService;
        public int Port { get; set; }

        public Server(Monitor monitor)
        {
            this.monitor = monitor;
            clients = new ArrayList();
            IsRunning = false;
        }

        public void Start()
        {
            byte[] adr = { 127, 0, 0, 1 };
            IPAddress ipAdr = new IPAddress(adr);
            listener = new TcpListener(ipAdr, Port);
            listener.Start();
            IsRunning = true;
            connectionsService = new Thread(new ThreadStart(waitForConnections));
            connectionsService.IsBackground = true;
            connectionsService.Start();
        }

        public void Stop()
        {
            if (IsRunning)
            {
                IsRunning = false;
                listener.Stop();
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
                bool registered = RegisterUser(user);
                if (!registered) //I don't like you
                    return;
                else
                {
                    monitor.Notify(user.username + " has registered."); //Welcome to my house !
                }
            } else { //Your face rings a bell ...
                bool authenticated = AuthenticateUser(user); //Okay let me put on my glasses

                if (authenticated) //Oh it's you ! It's been a while !
                {
                    monitor.AddUser(user);
                    monitor.Notify(user.username + " is connected.");
                    //SendMessageHistory(stream); //Here is what you missed
                }
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


                /*
                 * TO DO:
                 * save message to database
                */

                monitor.UserSays(user, msg);
            }

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
         * Registers a user in the database
         * Returns true if success
         */
        private bool RegisterUser(User user)
        {
            bool success = true;
            using (ViaChatEntities db = new ViaChatEntities())
            {
                db.Users.Add(user);
                try
                {
                    db.SaveChanges();
                }
                catch(Exception e)
                {
                    success = false;
                }
            }

            return success;
        }


        /*
         * Authenticates a user by checking if there is a record in the DB
         * where the useranme and password match
         */
        private bool AuthenticateUser(User user)
        {
            bool auth = false;
            using (ViaChatEntities db = new ViaChatEntities())
            {
                var query = from u in db.Users
                            where u.username == user.username
                                  && u.password == user.password
                            select u;

                if (query.FirstOrDefault<User>() != null)
                    auth = true;
            }

            return auth;
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
    }
}
