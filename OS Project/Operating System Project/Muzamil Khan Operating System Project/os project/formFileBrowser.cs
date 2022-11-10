using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class formFileBrowser : MetroFramework.Forms.MetroForm
    {
        List<string> listFiles = new List<string>();

        public formFileBrowser()
        {
            InitializeComponent();
        }

        private void formFileBrowser_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Clear all items
            listFiles.Clear();
            listView.Items.Clear();
            //Open folder browser dialog
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    //Set path to textbox
                    textBox1.Text = fbd.SelectedPath;
                    foreach (string item in Directory.GetFiles(fbd.SelectedPath))
                    {
                        //Add image to imagelist
                        imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listFiles.Add(fi.FullName);//Add file name to list
                        //Add file name and image to listview
                        listView.Items.Add(fi.Name, imageList.Images.Count - 1);
                    }
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null)
                Process.Start(listFiles[listView.FocusedItem.Index]); //Open process
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formFileBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formDashboard fd = new formDashboard();
            fd.Show();
            this.Hide();
        }
    }
}
