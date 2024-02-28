using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrowser_ve_panel_nesnesı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gıt_Click(object sender, EventArgs e)
        {
            string git = textBox1.Text;
            webBrowser1.Navigate(git);
        }

        private void btn_gerı_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            
        }

        private void btn_ılerı_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_reflesh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_sıl_Click(object sender, EventArgs e)
        {
            textBox1.Text=string.Empty;
        }
    }
}
