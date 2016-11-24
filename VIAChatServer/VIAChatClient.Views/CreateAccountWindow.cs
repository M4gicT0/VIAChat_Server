using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIAChatClient.Views
{
    public partial class CreateAccountWindow : Form
    {
        public CreateAccountWindow()
        {
            InitializeComponent();
        }

        private void registerByCreatingAccountbutton_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            // Make connection to database
            // Send the field to database
            //Return user to login window

            this.Hide();
            //LoginWindow loginWindow = new LoginWindow();
           // loginWindow.Show();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
