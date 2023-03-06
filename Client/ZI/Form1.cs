using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI
{
    public partial class Form1 : Form
    {
        Service.ServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new Service.ServiceClient();
        }


        private void btnLoadFileA52_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            if(dialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
               tbLoadFileA52.Text = dialog.FileName;
            }
        }

        private void btnSaveFileA52_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSaveFileA52.Text = dialog.FileName;
            }
        }

        private void btnEncypta52_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbLoadFileA52.Text) || string.IsNullOrWhiteSpace(tbLoadFileA52.Text) 
               || string.IsNullOrEmpty(tbSaveFileA52.Text) || string.IsNullOrWhiteSpace(tbSaveFileA52.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.EncryptA52Async(tbLoadFileA52.Text, tbSaveFileA52.Text);
        }

        private void btnA52Decrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadFileA52.Text) || string.IsNullOrWhiteSpace(tbLoadFileA52.Text)
              || string.IsNullOrEmpty(tbSaveFileA52.Text) || string.IsNullOrWhiteSpace(tbSaveFileA52.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.DecryptA52Async(tbLoadFileA52.Text, tbSaveFileA52.Text);
        }

        private void btnLoadBmpA52_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "bmp files (*.bmp)|*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbLoadBpmA52.Text = dialog.FileName;
            }
        }

        private void btnDecryptBmpA52_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadBpmA52.Text) || string.IsNullOrWhiteSpace(tbLoadBpmA52.Text)
              || string.IsNullOrEmpty(tbSaveBmpA52.Text) || string.IsNullOrWhiteSpace(tbSaveBmpA52.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.DecryptA52BMPAsync(tbLoadBpmA52.Text, tbSaveBmpA52.Text);
        }

        private void btnSaveBmpA52_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "bmp files (*.bmp)|*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSaveBmpA52.Text = dialog.FileName;
            }
        }

        private void bmpEncyptBmpA52_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadBpmA52.Text) || string.IsNullOrWhiteSpace(tbLoadBpmA52.Text)
             || string.IsNullOrEmpty(tbSaveBmpA52.Text) || string.IsNullOrWhiteSpace(tbSaveBmpA52.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.EncryptA52BMPAsync(tbLoadBpmA52.Text, tbSaveBmpA52.Text);
        }

        private void btnLoadFileRail_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbLoadFileRail.Text = dialog.FileName;
            }
        }

        private void btnSaveFileRail_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSaveFileRail.Text = dialog.FileName;
            }
        }

        private void btnEncryptRail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadFileRail.Text) || string.IsNullOrWhiteSpace(tbLoadFileRail.Text)
             || string.IsNullOrEmpty(tbSaveFileRail.Text) || string.IsNullOrWhiteSpace(tbSaveFileRail.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.EncryptRailFence(tbLoadFileRail.Text, tbSaveFileRail.Text);
        }

        private void btnDecryptRail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadFileRail.Text) || string.IsNullOrWhiteSpace(tbLoadFileRail.Text)
            || string.IsNullOrEmpty(tbSaveFileRail.Text) || string.IsNullOrWhiteSpace(tbSaveFileRail.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.DecryptRailDence(tbLoadFileRail.Text, tbSaveFileRail.Text);
        }

        private void btnLoadBMPRail_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "bmp files (*.bmp)|*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbLoadBMPRail.Text = dialog.FileName;
            }
        }

        private void btnSaveBMPRail_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "bmp files (*.bmp)|*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSaveBMPRail.Text = dialog.FileName;
            }
        }

        private void btnEncryptBMPRail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadBMPRail.Text) || string.IsNullOrWhiteSpace(tbLoadBMPRail.Text)
           || string.IsNullOrEmpty(tbSaveBMPRail.Text) || string.IsNullOrWhiteSpace(tbSaveBMPRail.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.EncryptRailFenceBMPAsync(tbLoadBMPRail.Text, tbSaveBMPRail.Text);
        }

        private void btnDecryptBMPRail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadBMPRail.Text) || string.IsNullOrWhiteSpace(tbLoadBMPRail.Text)
           || string.IsNullOrEmpty(tbSaveBMPRail.Text) || string.IsNullOrWhiteSpace(tbSaveBMPRail.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.DecryptRailDenceBMPAsync(tbLoadBMPRail.Text, tbSaveBMPRail.Text);
        }

       

        private void btnLoadFileXTEA_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbLoadFileXTEA.Text = dialog.FileName;
            }
        }

        private void btnSaveFileXTEA_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSaveFileXTEA.Text = dialog.FileName;
            }
        }

        private void btnEncryptXTEA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadFileXTEA.Text) || string.IsNullOrWhiteSpace(tbLoadFileXTEA.Text)
           || string.IsNullOrEmpty(tbSaveFileXTEA.Text) || string.IsNullOrWhiteSpace(tbSaveFileXTEA.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.EncryptXTEAAsync(tbLoadFileXTEA.Text, tbSaveFileXTEA.Text);
        }

        private void btnDecryptXTEA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadFileXTEA.Text) || string.IsNullOrWhiteSpace(tbLoadFileXTEA.Text)
          || string.IsNullOrEmpty(tbSaveFileXTEA.Text) || string.IsNullOrWhiteSpace(tbSaveFileXTEA.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.DecryptXTEAAsync(tbSaveFileXTEA.Text, tbSaveFileXTEA.Text);
        }

        private void btnLoadFilepcbc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbLoadFilepcbc.Text = dialog.FileName;
            }
        }

        private void btnSaveFilepcbc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSaveFilepcbc.Text = dialog.FileName;
            }
        }

        private void btnEncryptpcbc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadFilepcbc.Text) || string.IsNullOrWhiteSpace(tbLoadFilepcbc.Text)
          || string.IsNullOrEmpty(tbSaveFilepcbc.Text) || string.IsNullOrWhiteSpace(tbSaveFilepcbc.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.EncryptPCBCAsync(tbLoadFilepcbc.Text, tbSaveFilepcbc.Text);
        }

        private void btnDecryptpcbc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadFilepcbc.Text) || string.IsNullOrWhiteSpace(tbLoadFilepcbc.Text)
          || string.IsNullOrEmpty(tbSaveFilepcbc.Text) || string.IsNullOrWhiteSpace(tbSaveFilepcbc.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.DecryptPCBCAsync(tbLoadFilepcbc.Text, tbSaveFilepcbc.Text);
        }

        private void btnLoadBMPpcbc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "bmp files (*.bmp)|*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbLoadBmppcbc.Text = dialog.FileName;
            }
        }

        private void btnSaveBMPpcbc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.Filter = "bmp files (*.bmp)|*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSaveBmppcbc.Text = dialog.FileName;
            }
        }

        private void btnEncryptBmppcbc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadBmppcbc.Text) || string.IsNullOrWhiteSpace(tbLoadBmppcbc.Text)
          || string.IsNullOrEmpty(tbSaveBmppcbc.Text) || string.IsNullOrWhiteSpace(tbSaveBmppcbc.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.EncryptPCBCBMPAsync(tbLoadBmppcbc.Text, tbSaveBmppcbc.Text);
        }

        private void btnDecryptBmppcbc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadBmppcbc.Text) || string.IsNullOrWhiteSpace(tbLoadBmppcbc.Text)
          || string.IsNullOrEmpty(tbSaveBmppcbc.Text) || string.IsNullOrWhiteSpace(tbSaveBmppcbc.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            client.DecryptPCBCBMPAsync(tbLoadBmppcbc.Text, tbSaveBmppcbc.Text);
        }
        private void btnloadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbloadFile.Text = dialog.FileName;
            }
        }
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSaveFile.Text = dialog.FileName;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbloadFile.Text) || string.IsNullOrWhiteSpace(tbloadFile.Text)
          || string.IsNullOrEmpty(tbSaveFile.Text) || string.IsNullOrWhiteSpace(tbSaveFile.Text))
            {
                MessageBox.Show("Load File and Save file can't be empty");
                return;
            }
            bool ok = client.Md5hashAsync(tbloadFile.Text, tbSaveFile.Text).Result;
            if(ok)
                lblResult.Text = "Ok su";
            else
                lblResult.Text = "Nisu isti";

        }

        private void btnLoadTextp_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbLoadText.Text = dialog.FileName;
            }
        }

        private void btnSavefilep_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSaveText.Text = dialog.FileName;
            }
         
        }

        private void btnEncypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoadText.Text) || string.IsNullOrWhiteSpace(tbLoadText.Text)
          || string.IsNullOrEmpty(tbSaveText.Text) || string.IsNullOrWhiteSpace(tbSaveText.Text)
          || string.IsNullOrEmpty(tbthreads.Text) || string.IsNullOrWhiteSpace(tbthreads.Text))
            {
                MessageBox.Show("Load File and Save file and number of threads can't be empty");
                return;
            }
            client.EncryptParalelizationAsync(tbLoadText.Text, tbSaveText.Text,int.Parse(tbthreads.Text), 3);

        }
    }
}
