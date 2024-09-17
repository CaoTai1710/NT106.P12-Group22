using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openfiledialog_picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
           
            openFile.Filter = "Anh |*.jpg; *.gif; *.png; |All File|*.*";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show(openFile.SafeFileName);
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            } 
        }
    }
}
