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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Hide the current window
            // Show the Login window
            this.Hide();
         
            
        }

        private void creatAccountButton_Click(object sender, EventArgs e)
        {
            // Hide the current window
            // Show the create window
            this.Hide();
            CreateAccountWindow createAccountWindow = new CreateAccountWindow();
            createAccountWindow.Show();

        }
    }
}
