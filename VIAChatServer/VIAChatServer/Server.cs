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
            IsRunning = false;
            listener.Stop();
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

            User user = KnockKnock(stream);

            if (user == null)
                return;
            else if(user.toBeRegistered)
            {
                bool registered = RegisterUser(user);
                if (!registered)
                    return;
                else
                {
                    monitor.Notify(user.username + " has registered.");
                }
            } else {
                monitor.AddUser(user);
                monitor.Notify(user.username + " is connected.");
                //SendMessageHistory(stream);
            }


            while (IsRunning) //The communication is up until the client disconnects
            {
                /*
                 * TO DO:
                 * Read message (XML formatted)
                */

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

                Message msg = new Message();
                msg.body = Encoding.ASCII.GetString(data, 0, recv);
                msg.user_id = user.id;

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
                db.SaveChanges();
            }

            return success;
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
