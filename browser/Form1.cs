using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}

