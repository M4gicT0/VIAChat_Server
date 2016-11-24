using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIAChatClient
{
    public partial class LoginFormUserWindow : Form
    {


        byte[] data = new byte[1024];
        public string input, stringData;
        public int Port { get; set; }
        public TcpClient client;
        public Socket socket;
        public string IpAddress { get; set; }

        public LoginFormUserWindow()
        {
            InitializeComponent();

            // Disable the login button
        }

        private void logMeInButtonLog_Click(object sender, EventArgs e)
        {
            // Take all fields
            var userNameProvided = userNameTextBoxLog.Text;
            var passwordProvided = passwordTextBoxLog.Text;
            var ipProvided = ipAddressTextBoxLog.Text;
            var portProvided = portTextBoxLog.Text;
            // Ask for connection from the server
            // Check if the fields corresponds to the information to database
            //  If correct log in the user
            // Else show message box
        }

        private void backbButtonLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainWindow = new FormMainWindow();
            mainWindow.Show();
        }
    }
}
