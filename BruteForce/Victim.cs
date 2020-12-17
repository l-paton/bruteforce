using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteForce
{
    public partial class Victim : Form
    {
        public Victim()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form1.url = url.Text;
            Form1.paramName = paramName.Text;
            Form1.paramValue = paramValue.Text;
            Form1.keyName = keyName.Text;
            Form1.isJson = isJson.Checked;
            
            this.Close();
        }
    }
}
