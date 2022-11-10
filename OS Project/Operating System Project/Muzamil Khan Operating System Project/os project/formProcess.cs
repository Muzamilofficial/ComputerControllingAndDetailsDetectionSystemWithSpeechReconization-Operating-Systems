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
    public partial class formProcess : MetroFramework.Forms.MetroForm
    {
        public formProcess()
        {
            InitializeComponent();
        }

        private void formProcess_Load(object sender, EventArgs e)
        {
            LoadProcessesList();
        }

        private void LoadProcessesList()
        {
            listView1.Items.Clear();

            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                ListViewItem items = new ListViewItem(process.ProcessName);
                items.Tag = process;
                listView1.Items.Add(items);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formDashboard fd = new formDashboard();
            fd.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string text = metroTextBox1.Text;
            Process process = new Process();
            process.StartInfo.FileName = text;
            process.Start();
            LoadProcessesList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            Process process = (Process)item.Tag;
            process.Kill();
            LoadProcessesList();
        }
    }
}
