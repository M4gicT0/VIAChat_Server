using System;
using System.Windows.Forms;

namespace VIAChatClient
{
    public partial class LoginFormUserWindow : Form
    {
        private Client client;

        public LoginFormUserWindow()
        {
            InitializeComponent();

            client = new Client(this);
            logMeInButtonLog.Enabled = false; // Disable the login button

        }

        private void logMeInButtonLog_Click(object sender, EventArgs e)
        {
            String ip = ipAddressTextBoxLog.Text;
            int port = int.Parse(portTextBoxLog.Text);

            if (ip == "" && port == 0)
            {
                bool connected = client.Connect(ip, port);

                if (connected)
                {
                    if (client.LoginUser(userNameTextBoxLog.Text, passwordTextBoxLog.Text))
                    {
                        MessageBox.Show("User successfuly logged in !");
                        /*
                         * TO DO :
                         * Show chat window
                         */
                    }
                    else
                    {
                        MessageBox.Show("Login error !");
                    }
                }
                else
                {
                    MessageBox.Show("Error connecting to the server !");
                }
            }
            else
            {
                MessageBox.Show("Fields ip  and port address requied");
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
