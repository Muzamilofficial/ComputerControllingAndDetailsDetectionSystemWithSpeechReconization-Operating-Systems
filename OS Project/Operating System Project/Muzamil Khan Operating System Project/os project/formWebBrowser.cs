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
    public partial class formWebBrowser : MetroFramework.Forms.MetroForm
    {

        public formWebBrowser()
        {
            InitializeComponent();
        }

        private void formWebBrowser_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formWebBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formDashboard fd = new formDashboard();
            fd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || textBox1.Text.Equals("about:blank"))
            {
                MessageBox.Show("Enter a valid URL.");
                textBox1.Focus();
                return;
            }
            OpenURLInBrowser(textBox1.Text);
        }
        private void OpenURLInBrowser(string url)
        {

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            try
            {
                webBrowser1.Navigate(new Uri(url));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPropertiesDialog();
        }  
    }
}
