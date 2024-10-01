using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();   
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(dialog.SelectedPath);
                    textBox1.Text = dialog.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }
    }
}
