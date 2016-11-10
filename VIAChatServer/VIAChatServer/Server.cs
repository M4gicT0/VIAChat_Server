using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Linq;

namespace VIAChatServer
{
    class Server
    {
        private Monitor monitor;
        private TcpListener listener;
        private ArrayList clients;
        private bool isRunning;
        private Thread connectionsService;
        public int Port { get; set; }

        public Server(Monitor monitor)
        {
            this.monitor = monitor;
            clients = new ArrayList();
            isRunning = false;
        }

        public void Start()
        {
            byte[] adr = { 127, 0, 0, 1 };
            IPAddress ipAdr = new IPAddress(adr);
            listener = new TcpListener(ipAdr, Port);
            listener.Start();
            isRunning = true;
            connectionsService = new Thread(new ThreadStart(waitForConnections));
            connectionsService.Start();
        }

        public void Stop()
        {
            listener.Stop();
            isRunning = false;
        }

        public bool IsRunning()
        {
            return isRunning;
        }

        private void waitForConnections()
        {
            try
            {
                while (isRunning) //The thread has to be stopped from the inside, to prevent deadlocks
                {
                    TcpClient client = listener.AcceptTcpClient(); //Wait for an incoming connection
                    clients.Add(client);
                    new Thread(() => SocketThread(client.GetStream())).Start(); //Creates anonymous thread and pass stream parameter to the method being threaded
                }
            }
            catch(SocketException e)
            {
                Console.WriteLine(e);
            }
        }

        private void SocketThread(NetworkStream stream) //method being threaded, handles the socket communication
        {
            /*
             * TO DO (once):
             * Retrieve the client's userId from his username
             * Send back his userid
             * Send him the previous messages (from the database, XML or whatever)
             * 
             * foreach (messages as message)
             *      stream.Write(message.GetBody(), 0, message.length);
            */

            String userName = "John Doe";
            User user = FindUser(userName);
            monitor.AddUser(user);

            monitor.Notify(userName + " is connected.");

            while (true) //The communication is up until the client disconnects
            {
                byte byteRead = (byte)stream.ReadByte();
                /*
                 * TO DO:
                 * Read message (XML formatted)
                 * Save the message in the messages history
                 * once we receive a carriage return
                */
            }

        }

        private User FindUser(string username)
        {
            /*
             * Returns the user having the corresponding username
            */
            using (VIAChatEntities context = new VIAChatEntities())
            {
                var query =  from u in context.Users
                               where u.username == username
                               select u;

                return query.FirstOrDefault<User>();
            }
        }
    }
}
