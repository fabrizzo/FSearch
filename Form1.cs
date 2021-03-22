using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fsearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_url_Click(object sender, EventArgs e)
        {
            object fpath;
            fpath = folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textbox_url.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }
}
