using System;
using System.Net;
using System.Net.Sockets;
using VIAChatClient.Models;

namespace VIAChatClient
{
    class Client
    {
        private TcpClient tcpClient;
        private Socket socket;
        private User user;
        private System.Windows.Forms.Form view;

        public Client(System.Windows.Forms.Form view)
        {
            this.view = view;
        }

        public bool Connect(String ip, int port)
        {
            bool success = false;
            IPAddress ipAddr = IPAddress.Parse(ip); //Parse the String into an IPAddress object
            IPEndPoint remoteEP = new IPEndPoint(ipAddr, port);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Connect the socket to the remote endpoint. Catch any errors.
            try
            {
                socket.Connect(remoteEP);
                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e.ToString());
            }

            return success;
        }

        public bool RegisterUser(String username, String email, String password)
        {
            bool success = false;
            user = new User(username, email, password, true);


            return success;
        }

        public bool LoginUser(String username, String password)
        {
            bool success = false;
            user = new User(username, password);

            return success;
        }

        public void Close()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
