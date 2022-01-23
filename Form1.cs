using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Collections;

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

        private void find_button_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(textbox_url.Text);
            foreach (var fi in di.EnumerateFiles("*" + textBox1_KW.Text + "*", SearchOption.AllDirectories))
            {
                listBox1.Items.Add(fi.FullName);
            }

        }
        private void LoadDoc(string filename)
        {
            Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();
            object File = filename;
            object nullobject = System.Reflection.Missing.Value;
            wordObject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
            Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(ref File, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject);
            docs.ActiveWindow.Selection.WholeStory();
            docs.ActiveWindow.Selection.Copy();
            richTextBox1.Paste();
            docs.Close(ref nullobject, ref nullobject, ref nullobject);
            wordObject.Quit();
        }
        private void LoadTXT(string filename)
        {
            richTextBox1.Text = File.ReadAllText(filename, Encoding.Default);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string format;
            format = Path.GetExtension(listBox1.SelectedItem.ToString());
                switch (format)
            {
                case ".txt":
                    LoadTXT(listBox1.SelectedItem.ToString());
                    break;

                case ".doc":
                    LoadDoc(listBox1.SelectedItem.ToString());
                    break;

                case ".docx":
                    LoadDoc(listBox1.SelectedItem.ToString());
                    break;

                default:
                    MessageBox.Show("Неизвестный формат", listBox1.SelectedIndex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            
        }
        private void button_search_into_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(textbox_url.Text);
            foreach (var fi in di.EnumerateFiles("*.doc*", SearchOption.AllDirectories))
            {
                Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();
                object File = fi.ToString();
                object nullobject = System.Reflection.Missing.Value;
                wordObject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
                Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(ref File, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject);
                docs.ActiveWindow.Selection.WholeStory();
                docs.ActiveWindow.Selection.Find.Execute("*" + textBox1_KW.Text + "*");
                if (docs.ActiveWindow.Selection.Text.Length > 0)
                {
                    listBox1.Items.Add(fi.FullName);
                }
            }
        }
    }
}
