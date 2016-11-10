using System;
using System.Windows.Forms;

namespace VIAChatServer
{
    public partial class Monitor : Form
    {
        private Server server;

        public Monitor()
        {
            InitializeComponent();

            server = new Server();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {

        }

        private void adminInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            if (!server.IsRunning())
            {
                server.Start();
                buttonToggle.Text = "Stop";
            } else {
                server.Stop();
                buttonToggle.Text = "Start";
            }
        }
    }
}
