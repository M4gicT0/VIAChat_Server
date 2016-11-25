using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

// User from Common library 
using User;

namespace VIAChatClient
{
    public partial class CreateAccountWindow : Form
    {

        // For holding data
        public byte[] data = new byte[1024];
    
        public TcpClient client = new TcpClient();
        public Socket socket;
        public string IpAddress { get; set; }

        public User.User user;

        public CreateAccountWindow()
        {
            InitializeComponent();

            registerMeButton.Enabled = false;
        }

        private void registerMeButton_Click(object sender, EventArgs e)
        {
            user.username = userTextBox.Text;
            user.email = emailTextBox.Text;
            user.password = passwordTextBox.Text;
            user.toBeRegistered = true;
            var hostnameProvided = hostIPAddressTextBoxCreate.Text;
            var portNameProvided = int.Parse(portTextBoxCreate.Text);
          

            // Take all the fields
            //Check if there is any missing field or is set to empy, 
            //If so return an error with Message box
            //Else process the fields
            // Attempt to connect to the server using socket
            // Return user to the main login 
            try
            {
                // Port should not be 0
                if (hostnameProvided == "" && portNameProvided == 0 && user.username.Trim() == "" &&
                    user.password.Trim() == "")
                {

                    // Connect to server

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
                       XmlSerializer serializer = new XmlSerializer(typeof(User.User));
                        using (MemoryStream stream = new MemoryStream(data))
                        {
                            serializer.Serialize(stream,this);
                        }

                        socket.Send(data);  // Send the byte data

                        // Then open the new window
                        this.Hide();
                        LoginFormUserWindow loginFormUserWindow = new LoginFormUserWindow();
                        loginFormUserWindow.Show();
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

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            // Return to the main window
            this.Hide();
           var mainWindow = new FormMainWindow();
            mainWindow.Show();
        }
    }
}
