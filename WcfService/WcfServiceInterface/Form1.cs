using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfServiceInterface
{
    public partial class Form1 : Form
    {
        private ServiceHost host;
        public Form1()
        {
            InitializeComponent();
            host = new ServiceHost(typeof(WcfService.Service1));
            host.Open();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblStatus.Text = "Service Started";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(WcfService.Service1));
            host.Open();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblStatus.Text = "Service Started";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {            
            host.Close();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.Text = "Service Stopped";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            host.Close();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
