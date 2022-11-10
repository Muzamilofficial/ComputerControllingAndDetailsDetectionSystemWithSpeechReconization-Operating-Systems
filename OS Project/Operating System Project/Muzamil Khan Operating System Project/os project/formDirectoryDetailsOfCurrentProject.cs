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

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class formDirectoryDetailsOfCurrentProject : MetroFramework.Forms.MetroForm
    {
        public formDirectoryDetailsOfCurrentProject()
        {
            InitializeComponent();
        }

        private void formDirectoryDetailsOfCurrentProject_Load(object sender, EventArgs e)
        {
            ShowDetails();
        }

        public void ShowDetails()
        {
            string rootpath = @"C:\Users\Dw\Desktop\Operating System Project\Muzamil Khan Operating System Project";
            string[] dirs = Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories);
            var files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            foreach (string dir in dirs)
            {
                richTextBox1.Text = dir;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formFileDetailSystem fs = new formFileDetailSystem();
            fs.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formDirectoryDetailsOfCurrentProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
