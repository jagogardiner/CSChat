using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ClientServerChat
{
    public partial class LaunchForm : Form
    {
        public LaunchForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            launchComboBox.Items.Add("Server");
            launchComboBox.Items.Add("Client");
            launchComboBox.SelectedIndex = 0;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            string m = launchComboBox.SelectedItem.ToString();
            this.Visible = false;
            switch (m)
            {
                case "Server":
                    Debug.WriteLine("Server selected");
                    Server.Launch();
                    break;
                case "Client":
                    Debug.WriteLine("Client selected");
                    Client.Launch();
                    break;
                default:
                    MessageBox.Show("I have no clue how you managed to select that. Have a medal!");
                    break;
            }
        }
    }
}
