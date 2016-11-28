using System.Windows.Forms;

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
        }

        public void Alert(string message)
        {
            MessageBox.Show(message);
        }

        private void PopulateOnlineUsers()
        {
        }

        private void sendMessageButton_Click(object sender, System.EventArgs e)
        {
            
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
