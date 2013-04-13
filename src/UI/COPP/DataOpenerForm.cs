using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace COPP
{
    public partial class DataOpenerForm : Form
    {
        public DataOpenerForm()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                textBoxFile.Text = openFileDialog1.FileName;
            }
        }


        private StreamReader ReadFromFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            return sr;
        }

        private StreamReader ReadFromURL(string url)
        {
            WebClient cli = new WebClient();
            cli.DownloadFile(url, "temp.txt");
            return ReadFromFile("temp.txt");
        }

        public StreamReader GetStream()
        {
            if (radioButtonFile.Checked)
            {
                return ReadFromFile(textBoxFile.Text);
            }
            else return ReadFromURL(textBoxURL.Text);
        }



    }
}
