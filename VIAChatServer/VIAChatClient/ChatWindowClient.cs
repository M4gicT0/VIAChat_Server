using System;
using System.Windows.Forms;
using VIAChatClient.Models;

namespace VIAChatClient
{
    public partial class ChatWindowClient : Form, View
    {
        private ClientController client;

        public ChatWindowClient()
        {
            InitializeComponent();

            client = new ClientController(this);
            PopulateOnlineUsers();
            PopulateMessageHistory();
            client.StartListening();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Stop the socket before closing the application
            client.Close();
            base.OnFormClosing(e);
            Application.Exit();
        }

        public void Alert(string message)
        {
            MessageBox.Show(message);
        }

        public void AddMessage(string message)
        {
            this.Invoke((MethodInvoker)delegate {
                conversationBox.AppendText(message);
            });
        }

        private void PopulateOnlineUsers()
        {
            string[] onlineUsers = client.ReceiveOnlineUsersList();

            for(int i = 0; i < onlineUsers.Length; i++)
            {
                usersList.AppendText(onlineUsers[i]);
            }
        }

        private void PopulateMessageHistory()
        {
            string[] history = client.ReceiveHistory();

            for(int i = 0; i < history.Length; i++)
            {
                conversationBox.AppendText(history[i]);
            }
        }

        private void sendMessageButton_Click(object sender, System.EventArgs e)
        {
            string body = messageInput.Text;
            messageInput.Text = "";

            if (client.SendMessage(body))
            {
                conversationBox.AppendText("You: " + body + "\n");
            } else
            {
                MessageBox.Show("Error sending message !");
            }
        }

        private void messageInput_TextChanged(object sender, System.EventArgs e)
        {
            if (messageInput.Text.Length > 0)
                sendMessageButton.Enabled = true;
            else
                sendMessageButton.Enabled = false;
        }
    }
}
