using System;
using System.Windows.Forms;

namespace ClientServerChat
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void SetConfigButton_Click(object sender, EventArgs e)
        {
            string address = AddressConfigBox.Text;
            int port = Convert.ToInt32(PortConfig.Value);
            int delay = Convert.ToInt32(DelayConfig.Value);
            Server.SetConfiguration(address, port, delay);
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            Server.Configuration config = Server.GetConfiguration();
            AddressConfigBox.Text = config.address;
            PortConfig.Value = config.port;
            DelayConfig.Value = config.delay;
        }
    }
}
