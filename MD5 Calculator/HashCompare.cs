using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MD5_Calculator
{
    public partial class HashCompare : Form
    {
        string fileName = "", hashvalue = "";

        public HashCompare()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (ofdHC.ShowDialog() == DialogResult.OK)
            {
                fileName = ofdHC.FileName;
                txtSelectFile.Text = fileName;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (btnMd5.Checked && fileName != "" )
            {
                hashvalue = FileHasher.MD5Hash(fileName);
                ShowMsg(hashvalue,txtHash.Text);
            }

            else if (btnSha1.Checked && fileName != null)
            {
                hashvalue = FileHasher.SHA1Hash(fileName);
                ShowMsg(hashvalue, txtHash.Text);
            }

            else if (btnSha256.Checked && fileName != null)
            {
                hashvalue = FileHasher.SHA256Hash(fileName);
                ShowMsg(hashvalue, txtHash.Text);
            }

            else if (btnSha384.Checked && fileName != null)
            {
                hashvalue = FileHasher.SHA384Hash(fileName);
                ShowMsg(hashvalue, txtHash.Text);
            }

            else if (btnSha512.Checked && fileName != null)
            {
                hashvalue = FileHasher.SHA512Hash(fileName);
                ShowMsg(hashvalue, txtHash.Text);
            }
            else
            {
                MessageBox.Show("Enter all datas");
            }
        }

        public void ShowMsg(string fileHash, string enteredHash)
        {
            int value = string.Compare(fileHash, enteredHash.ToLower());

            if(value == 0)
            {
                MessageBox.Show("File is Secure ","Correct Hash",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tampered File","Incorrect Hash",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void HashCompare_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the Dataformat of the data can be accepted
            // (we only accept file drops from Explorer, etc.)

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                e.Effect = DragDropEffects.Copy; // Okay
            }
            else
            {
                e.Effect = DragDropEffects.None; // Unknown data, ignore it
            }
        }

        private void HashCompare_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            fileName = FileList[0];
            ofdHC.FileName = FileList[0];
            txtSelectFile.Text = FileList[0];
        }

    }
}
