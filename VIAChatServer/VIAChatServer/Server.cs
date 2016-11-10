using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace VIAChatServer
{
    class Server
    {
        private TcpListener listener;
        private ArrayList clients;
        private bool isRunning;
        private Thread connectionsService;
        public int Port { get; private set; }

        public Server(int port)
        {
            this.Port = port;
            byte[] adr = { 127, 0, 0, 1 };
            IPAddress ipAdr = new IPAddress(adr);
            listener = new TcpListener(ipAdr, port);
            clients = new ArrayList();
            isRunning = false;
        }

        public void Start()
        {
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
                while (isRunning) //Infinite loop because it's the only job of the server
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
             * Send the previous messages (from the database, XML or whatever)
             * to the client.
             * 
             * foreach (messages as message)
             *      stream.Write(message.GetBody(), 0, message.length);
            */
            String userName = "";


            User user = new User(userName);
            Message message = new Message(user);

            while (true) //The communication is up until the client disconnects
            {
                byte byteRead = (byte)stream.ReadByte();
                /*
                 * TO DO:
                 * Save the message in the messages history
                 * once we receive a carriage return
                */
            }

        }
    }
}
