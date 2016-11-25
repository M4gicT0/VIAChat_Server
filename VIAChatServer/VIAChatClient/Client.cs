using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using VIAChatClient.Models;

namespace VIAChatClient
{
    class Client
    {
        private Socket socket;
        private User user;
        private View view;

        public Client(View view)
        {
            this.view = view;
        }

        public bool Connect(String ip, int port)
        {
            bool success = false;
            IPAddress ipAddr = null;

            try
            {
                ipAddr = IPAddress.Parse(ip); //Parse the String into an IPAddress object
            }
            catch(Exception e)
            {
                view.Alert("Bad IP address !");
            }

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
            XmlSerializer serializer = new XmlSerializer(typeof(User));
            MemoryStream memoryStream = new MemoryStream();

            using (StreamWriter writer = new StreamWriter(memoryStream, Encoding.UTF8))
            {
                serializer.Serialize(writer, user);
                byte[] utf8EncodedXml = memoryStream.ToArray();
                socket.Send(utf8EncodedXml);
            }

            int recv = 0;
            byte[] data = new byte[1024];
            Response response = null;

            while (recv == 0)
            {
                try
                {
                    recv = socket.Receive(data);
                }
                catch (IOException)
                {
                    Console.WriteLine("TCP error");
                }
            }

            serializer = new XmlSerializer(typeof(Response));

            using (MemoryStream ms = new MemoryStream(data))
            {
                response = (Response)serializer.Deserialize(ms);

                if (response.success)
                    success = true;
                else
                    view.Alert(response.body);
            }

            return success;
        }

        public bool LoginUser(String username, String password)
        {
            bool success = false;
            user = new User(username, password);
            XmlSerializer serializer = new XmlSerializer(typeof(User));
            MemoryStream memoryStream = new MemoryStream();

            using (StreamWriter writer = new StreamWriter(memoryStream, Encoding.UTF8))
            {
                serializer.Serialize(writer, user);
                byte[] utf8EncodedXml = memoryStream.ToArray();
                socket.Send(utf8EncodedXml);
            }

            int recv = 0;
            byte[] data = new byte[1024];
            Response response = null;

            while (recv == 0)
            {
                try
                {
                    recv = socket.Receive(data);
                }
                catch (IOException)
                {
                    Console.WriteLine("TCP error");
                }
            }

            serializer = new XmlSerializer(typeof(Response));

            using (MemoryStream ms = new MemoryStream(data))
            {
                response = (Response)serializer.Deserialize(ms);

                if (response.success)
                    success = true;
                else
                    view.Alert(response.body);
            }

            return success;
        }

        public void Close()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
