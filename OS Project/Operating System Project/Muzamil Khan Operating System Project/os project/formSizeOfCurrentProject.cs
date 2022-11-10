using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class formSizeOfCurrentProject : MetroFramework.Forms.MetroForm
    {
        public formSizeOfCurrentProject()
        {
            InitializeComponent();
        }

        private void formSizeOfCurrentProject_Load(object sender, EventArgs e)
        {
            ShowDetails();
        }
        public void ShowDetails()
        {
            //DirectoryInfo info = new DirectoryInfo(@"C:\Users\Dw\Desktop\Operating System Project\Muzamil Khan Operating System Project");
            //long totalSize = info.EnumerateFiles().Sum(file => file.Length);
            //info.EnumerateDirectories();

            //richTextBox1.Text = totalSize.ToString();

            DirectoryInfo dInfo = new DirectoryInfo(@"C:\Users\Dw\Desktop\Operating System Project");
            long sizeOfDir = DirectorySize(dInfo, true);
            label1.Text = "Directory size in Bytes : " + "Bytes";
            label4.Text = sizeOfDir.ToString();
            label2.Text = "Directory size in KB : " + "KB";
            double var1 = sizeOfDir / 1024;
            label5.Text = var1.ToString();
            label3.Text = "Directory size in MB : " + "MB";
            double var2 = sizeOfDir / (1024 * 1024);
            label6.Text = var2.ToString();
        }
        static long DirectorySize(DirectoryInfo dInfo, bool includeSubDir)
        {
            long totalSize = dInfo.EnumerateFiles()
                         .Sum(file => file.Length);
            if (includeSubDir)
            {
                totalSize += dInfo.EnumerateDirectories()
                         .Sum(dir => DirectorySize(dir, true));
            }
            return totalSize;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formFileDetailSystem fs = new formFileDetailSystem();
            fs.Show();
            this.Hide();
        }

        private void formSizeOfCurrentProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
