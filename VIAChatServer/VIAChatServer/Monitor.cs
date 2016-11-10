using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            server = new Server(5577, this);
        }

        private void Monitor_Load(object sender, EventArgs e)
        {

        }

        private void adminInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            if (!server.IsRunning())
            {
                server.Start();
                messagesBox.AppendText("Server is running on port " + server.Port + ".\n");
                buttonToggle.Text = "Stop";
            } else {
                server.Stop();
                messagesBox.AppendText("Server stopped.\n");
                buttonToggle.Text = "Start";
            }
        }

        public void Notify(String message)
        {
            messagesBox.AppendText(message + "\n");
        }

        private void refreshConnectedUsersList()
        {
            foreach (User user in connectedUsers)
            {
                usersList.AppendText(user.username + "\n");
            }
        }

        public void AddUser(User user)
        {
            connectedUsers.Add(user);
            refreshConnectedUsersList();
        }
    }
}
