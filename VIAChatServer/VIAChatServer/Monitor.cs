using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIAChatServer
{
    public partial class Monitor : Form
    {
        private Server server;
        private List<User> connectedUsers;

        public Monitor()
        {
            InitializeComponent();
            connectedUsers = new List<User>();
            server = new Server(this);
        }

        private void Monitor_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //Stop the connections thread before closing the application
            server.Stop();
        }

        private void adminInput_TextChanged(object sender, EventArgs e)
        {
            /*
             * TO DO:
             * When the character is the carriage return,
             * flush the input and send the collected message
             * to every connected user, plus save it in the DB
            */
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            if (!server.IsRunning)
            {
                if (portInput.Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("You need to enter a port number !", "Port missing !");

                    return;
                }

                server.Port = int.Parse(portInput.Text);
                server.Start();
                messagesBox.AppendText("Server is running on port " + server.Port + ".\n");
                buttonToggle.Text = "Stop";
            } else {
                server.Stop();
                messagesBox.AppendText("Server stopped.\n");
                buttonToggle.Text = "Start";
            }
        }

        /*
         * Gets called by the server instance
        */
        public void Notify(String message)
        {
            this.Invoke((MethodInvoker)delegate {
                messagesBox.AppendText(message + "\n");
            });
        }

        private void refreshConnectedUsersList()
        {
            if(connectedUsers.Count == 0)
            {
                usersList.Text = "";

                return;
            }
            foreach (User user in connectedUsers)
            {
                this.Invoke((MethodInvoker)delegate {
                    usersList.AppendText(user.username + "\n");
                });
            }
        }

        /*
         * Gets called by the server instance
        */
        public void AddUser(User user)
        {
            connectedUsers.Add(user);
            refreshConnectedUsersList();
        }

        public void ResetOnlineUsers()
        {
            connectedUsers.Clear();
            refreshConnectedUsersList();
        }

        public void UserSays(User user, Message message)
        {
            this.Invoke((MethodInvoker)delegate {
                messagesBox.AppendText(user.username + ": " + message.body + "\n");
            });
        }
    }
}
