using System;
using System.Windows.Forms;

namespace VIAChatClient
{
    public partial class CreateAccountWindow : Form, View
    {
        private Client client;

        public CreateAccountWindow()
        {
            InitializeComponent();

            client = new Client(this);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Stop the socket before closing the application
            client.Close();
            base.OnFormClosing(e);
        }

        private void registerMeButton_Click(object sender, EventArgs e)
        {

            if (hostIPAddressTextBoxCreate.Text == "" || portTextBoxCreate.Text == "")
            {
                MessageBox.Show("IP Address and Port mustn't be empty !");

                return;
            }

            String ip = hostIPAddressTextBoxCreate.Text;
            int port = int.Parse(portTextBoxCreate.Text);
            bool connected = client.Connect(ip, port);

            if(connected)
            {
                if(client.RegisterUser(userTextBox.Text, emailTextBox.Text, passwordTextBox.Text))
                {
                    MessageBox.Show("User successfuly registered !");
                    this.Hide();
                    LoginFormUserWindow loginFormUserWindow = new LoginFormUserWindow();
                    loginFormUserWindow.Show();
                } else {
                    MessageBox.Show("Error registering user !");
                }
            } else {
                MessageBox.Show("Error connecting to the server !");
            }
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            // Return to the main window
            this.Hide();
           var mainWindow = new FormMainWindow();
            mainWindow.Show();
        }

        public void Alert(string message)
        {
            MessageBox.Show(message);
        }
    }
}
