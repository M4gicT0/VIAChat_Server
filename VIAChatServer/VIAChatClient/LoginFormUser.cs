using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using VIAChatClient.Models;

namespace VIAChatClient
{
    public partial class LoginFormUserWindow : Form
    {


        byte[] data = new byte[1024];
        public string input, stringData;
        public int Port { get; set; }
        public TcpClient client;
        public Socket socket;
        private User user;

        public LoginFormUserWindow()
        {
            InitializeComponent();

            // Disable the login button
            logMeInButtonLog.Enabled = false;

        }

        private void logMeInButtonLog_Click(object sender, EventArgs e)
        {
            
            user = new User(userNameTextBoxLog.Text, passwordTextBoxLog.Text);

            var hostnameProvided = ipAddressTextBoxLog.Text;
            var portNameProvided = int.Parse(portTextBoxLog.Text);
            // Ask for connection from the server
            // Check if the fields corresponds to the information to database
            //  If correct log in the user
            // Else show message box

            // Take all the fields
            //Check if there is any missing field or is set to empy, 
            //If so return an error with Message box
            //Else process the fields
            // Attempt to connect to the server using socket
            // Take user to Chat room
            try
            {
                // Port should not be 0
                if (hostnameProvided == "" && portNameProvided == 0 && user.username.Trim() == "" &&
                    user.password.Trim() == "")
                {

                    // Connect to 

                    // While loop ask for connection, show attemps on console
                    int attempConnect = 0;
                    while (!socket.Connected)
                    {
                        try
                        {
                            attempConnect++;
                            socket.Connect(hostnameProvided, portNameProvided);
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Connection attemp to the server : " + attempConnect.ToString());
                        }
                        Console.Clear();
                        Console.WriteLine("Connected to the server");
                    }

                    // End while loop to ask for connection

                    // Connected if statement after while loop for socket connection
                    if (socket.Connected)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(User));
                        using (MemoryStream stream = new MemoryStream(data))
                        {
                            serializer.Serialize(stream, this);
                        }

                        socket.Send(data);  // Send the byte data

                        // Then take user to the Chat Window
                        
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }

                    // End if statement connected
                }
                else
                {
                    MessageBox.Show("Fields ip  and port address requied");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void backbButtonLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainWindow = new FormMainWindow();
            mainWindow.Show();
        }
    }
}
