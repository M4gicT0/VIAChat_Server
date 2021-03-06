﻿using System;
using System.Windows.Forms;

namespace VIAChatClient
{
    public partial class CreateAccountWindow : Form, View
    {
        private ClientController client;

        public CreateAccountWindow()
        {
            InitializeComponent();

            client = new ClientController(this);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Stop the socket before closing the application
            client.Close();
            base.OnFormClosing(e);
            Application.Exit();
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
                    (new LoginFormUserWindow()).Show();
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
            this.Close();
           var mainWindow = new FormMainWindow();
            mainWindow.Show();
        }

        public void Alert(string message)
        {
            MessageBox.Show(message);
        }

        public void AddMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
