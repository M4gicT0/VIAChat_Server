using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIAChatClient
{
    public partial class CreateAccountWindow : Form
    {
        public CreateAccountWindow()
        {
            InitializeComponent();
            registerMeButton.Enabled = false;
        }

        private void registerMeButton_Click(object sender, EventArgs e)
        {
            var userNameRegister = userTextBox.Text;
            var emailRegister = emailTextBox.Text;
            var passwordRegister = passwordTextBox.Text;
            
            // Take all the fields
            //Check if there is any missing field, 
            //If so return an error with Message box
            //Else process the fields
            // Return user to the main login 
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
