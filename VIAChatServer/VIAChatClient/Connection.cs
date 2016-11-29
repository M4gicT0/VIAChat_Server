using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VIAChatClient.Models;

namespace VIAChatClient
{
    class Connection
    {
       
        private static Connection instance;
        private Socket socket;
        public User User { get; set; }

        private Connection() { }

        public static Connection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Connection();
                }
                return instance;
            }
        }

        public void Connect(IPAddress ipAddr, int port)
        {

            IPEndPoint remoteEP = new IPEndPoint(ipAddr, port);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(remoteEP);
        }

        public void Send(byte[] data)
        {
            socket.Send(data);
        }

        public int Receive(byte[] data)
        {
            return socket.Receive(data);
        }

        public void Close()
        {
            if(socket != null && socket.Connected)
            {
                socket.Disconnect(false);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }

        public bool IsRunning()
        {
            return socket.Connected;
        }
    }
}
