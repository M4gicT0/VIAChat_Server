using System;
using System.Windows.Forms;

namespace VIAChatClient
{
    public partial class CreateAccountWindow : Form
    {
        private Client client;

        public CreateAccountWindow()
        {
            InitializeComponent();

            client = new Client(this);
            registerMeButton.Enabled = false;
        }

        private void registerMeButton_Click(object sender, EventArgs e)
        {
            bool connected = client.Connect(hostIPAddressTextBoxCreate.Text, int.Parse(portTextBoxCreate.Text));

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
    }
}
