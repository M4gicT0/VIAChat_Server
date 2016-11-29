using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIAChatClient
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Take to Login window
            (new LoginFormUserWindow()).Show();
            this.Hide();

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new CreateAccountWindow()).Show();
        }
    }
}
