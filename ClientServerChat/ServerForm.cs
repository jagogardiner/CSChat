using System;
using System.Windows.Forms;

namespace ClientServerChat
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            configuration.Show();
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* Seeming as the Launch form was only hidden, and not closed, we need to close the entire application on exit. */
            Environment.Exit(0);
        }

        private void killInstanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server.SendRestart();
        }
    }
}
