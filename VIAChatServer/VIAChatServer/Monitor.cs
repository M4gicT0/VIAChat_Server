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

            server = new Server(5577);
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
                messagesBox.AppendText("Server is running on port " + server.Port + ".\n");
                buttonToggle.Text = "Stop";
            } else {
                server.Stop();
                messagesBox.AppendText("Server stopped.\n");
                buttonToggle.Text = "Start";
            }
        }
    }
}
