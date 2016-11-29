using System;
using System.Windows.Forms;

namespace VIAChatClient
{
    public partial class LoginFormUserWindow : Form, View
    {
        private ClientController client;

        public LoginFormUserWindow()
        {
            InitializeComponent();

            client = new ClientController(this);
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            client.Close();
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void logMeInButtonLog_Click(object sender, EventArgs e)
        {
            if (ipAddressTextBoxLog.Text == "" || portTextBoxLog.Text == "")
            {
                MessageBox.Show("IP Address and Port mustn't be empty !");

                return;
            }

            String ip = ipAddressTextBoxLog.Text;
            int port = int.Parse(portTextBoxLog.Text);
           
            bool connected = client.Connect(ip, port);

            if (connected)
            {
                if (client.LoginUser(userNameTextBoxLog.Text, passwordTextBoxLog.Text))
                {
                    MessageBox.Show("User successfuly logged in !");
                    this.Hide();
                    (new ChatWindowClient()).Show();
                }
            }
            else
            {
                MessageBox.Show("Error connecting to the server !");
            }
        }

        private void backbButtonLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FormMainWindow()).Show();
        }

        public void Alert(String message)
        {
            MessageBox.Show(message);
        }
    }
}
