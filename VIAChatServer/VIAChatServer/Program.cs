using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace VIAChatServer
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Server
    {
        private TcpListener listener;

        public Server()
        {
            byte[] adr = { 127, 0, 0, 1 };
            IPAddress ipAdr = new IPAddress(adr);
            listener = new TcpListener(ipAdr, 5549);
        }

        public void start()
        {
            listener.Start();

            while (true) //Infinite loop because it's the only job of the server
            {
                TcpClient client = listener.AcceptTcpClient(); //Wait for an incoming connection
                new Thread(() => SocketThread(client.GetStream())).Start(); //Creates anonymous thread and pass stream parameter to the method being threaded
            }
        }

        private void SocketThread(NetworkStream stream) //method being threaded, handles the socket communication
        {

        }

    }
}
