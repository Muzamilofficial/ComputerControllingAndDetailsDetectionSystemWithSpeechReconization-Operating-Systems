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
using System.Management;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class formDetailsOfCurrentProject : MetroFramework.Forms.MetroForm
    {
        List<string> listFiles = new List<string>();
        public formDetailsOfCurrentProject()
        {
            InitializeComponent();
        }

        private void formDetailsOfCurrentProject_Load(object sender, EventArgs e)
        {
            textBox1.Text = @"C:\Users\Dw\Desktop\Operating System Project\Muzamil Khan Operating System Project\Muzamil Khan Operating System Project";
            ShowDetails();
        }
        public void ShowDetails()
        {
            //Clear all items
            listFiles.Clear();
            listView.Items.Clear();
            //Open folder browser dialog
            //using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            //{
            //    if (fbd.ShowDialog() == DialogResult.OK)
            //    {
            //Set path to textbox
            //textBox1.Text = fbd.SelectedPath;
            foreach (string item in Directory.GetFiles(textBox1.Text))
            {
                //Add image to imagelist
                imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                FileInfo fi = new FileInfo(item);
                listFiles.Add(fi.FullName);//Add file name to list
                //Add file name and image to listview
                listView.Items.Add(fi.Name, imageList.Images.Count - 1);
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formFileDetailSystem fsd = new formFileDetailSystem();
            fsd.Show();
            this.Hide();
        }

        private void formDetailsOfCurrentProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null)
                Process.Start(listFiles[listView.FocusedItem.Index]); //Open process
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowDetails();
        }
    }
}
