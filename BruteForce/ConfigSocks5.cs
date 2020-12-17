using MihaZupan;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace BruteForce
{
    public partial class ConfigSocks5 : Form
    {
        public ConfigSocks5()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var proxy = new HttpToSocks5Proxy(proxyIp.Text, Int16.Parse(proxyPort.Text));
                var handler = new HttpClientHandler { Proxy = proxy };
                Form1.handler = handler;
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
