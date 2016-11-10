using System;
using System.Net;
using System.Net.Sockets;
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
        }
    }
}
