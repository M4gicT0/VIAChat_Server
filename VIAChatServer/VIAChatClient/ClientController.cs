﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using VIAChatClient.Models;

namespace VIAChatClient
{
    class ClientController
    {
        private Connection connection;
        private User user;
        private View view;
        private Thread listen;
        private bool sending; //Semaphor for receiving/sending messages

        public ClientController(View view)
        {
            this.view = view;
            connection = Connection.Instance;
            sending = false;
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
            
            // Connect the socket to the remote endpoint. Catch any errors.
            try
            {
                connection.Connect(ipAddr, port);
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
                connection.Send(utf8EncodedXml);
            }

            int recv = 0;
            byte[] data = new byte[1024];
            Response response = null;

            while (recv == 0)
            {
                try
                {
                    recv = connection.Receive(data);
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
                connection.Send(utf8EncodedXml);
            }

            int recv = 0;
            byte[] data = new byte[1024];
            Response response = null;

            while (recv == 0)
            {
                try
                {
                    recv = connection.Receive(data);
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
                {
                    connection.User = user;
                    success = true;
                }
                else
                    view.Alert(response.body);
            }

            return success;
        }


        public void StartListening()
        {
            if(listen == null)
                listen = new Thread(() => ListenForMessagesThread());

            listen.Start();//Start a thread for incoming messages
        }

        /*
         * Thread waiting for incoming messages
         */
        private void ListenForMessagesThread()
        {
            byte[] okay = Encoding.UTF8.GetBytes("OK");
            int recv = 0;
            byte[] data = new Byte[1024];

            while (connection.IsRunning())
            {
                recv = 0;
                data = new Byte[1024];

                while (recv == 0 && !sending)
                {
                    try
                    {
                        connection.ReadTimeout(100);
                        recv = connection.Receive(data);
                        string message = Encoding.UTF8.GetString(data);
                        view.AddMessage(message);
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("TCP error");
                    }
                }
            }
        }


        public bool SendMessage(String body)
        {
            listen.Suspend();
            connection.ReadTimeout(0);
            bool success = false;
            Message message = new Message(body);
            XmlSerializer serializer = new XmlSerializer(typeof(Message));
            MemoryStream memoryStream = new MemoryStream();

            using (StreamWriter writer = new StreamWriter(memoryStream, Encoding.UTF8))
            {
                serializer.Serialize(writer, message);
                byte[] utf8EncodedXml = memoryStream.ToArray();
                connection.Send(utf8EncodedXml);
            }

            int recv = 0;
            byte[] data = new byte[1024];
            byte[] okay = Encoding.UTF8.GetBytes("OK");
            Response response = null;

            while (recv == 0)
            {
                try
                {
                    recv = connection.Receive(data);
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
                {
                    success = true;
                }
                else
                    view.Alert(response.body);
            }

            connection.Send(okay);
            listen.Resume();

            return success;
        }

        public string[] ReceiveOnlineUsersList()
        {
            byte[] nbUsrs = new Byte[4];
            byte[] okay = Encoding.UTF8.GetBytes("OK");
            connection.Receive(nbUsrs);
            int nbUsers = BitConverter.ToInt32(nbUsrs, 0);
            string[] onlineUsers = new String[nbUsers];

            for (int i = 0; i < nbUsers; i++)
            {
                int recv = 0;
                byte[] data = new byte[1024];

                while (recv == 0)
                {
                    try
                    {
                        recv = connection.Receive(data);
                        onlineUsers[i] = Encoding.UTF8.GetString(data);
                        connection.Send(okay); //Send okay, and then be ready to receive the next entry
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("TCP error");
                    }
                }                
            }

            return onlineUsers;
        }

        public string[] ReceiveHistory()
        {
            string[] history = null;
            byte[] nbMsgs = new Byte[4];
            byte[] okay = Encoding.UTF8.GetBytes("OK");
            connection.Receive(nbMsgs);
            int nbMessages = BitConverter.ToInt32(nbMsgs, 0);
            history = new String[nbMessages];

            for(int i = 0; i < nbMessages; i++)
            {
                int recv = 0;
                byte[] data = new Byte[1024];

                while (recv == 0)
                {
                    try
                    {
                        recv = connection.Receive(data);
                        history[i] = Encoding.UTF8.GetString(data);
                        connection.Send(okay); //Send okay, and then be ready to receive the next entry
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("TCP error");
                    }
                }
            }

            return history;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
