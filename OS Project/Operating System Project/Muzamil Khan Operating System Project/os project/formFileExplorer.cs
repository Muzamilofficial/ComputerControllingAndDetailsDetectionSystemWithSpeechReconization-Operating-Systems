using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class formFileExplorer : MetroFramework.Forms.MetroForm
    {
        public formFileExplorer()
        {
            InitializeComponent();
        }

        private void formFileExplorer_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Open browser dialog allows you to select the path
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(fbd.SelectedPath);
                    textBox1.Text = fbd.SelectedPath;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formDashboard fss = new formDashboard();
            this.Hide();
            fss.Show();
        }

        private void formFileExplorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
