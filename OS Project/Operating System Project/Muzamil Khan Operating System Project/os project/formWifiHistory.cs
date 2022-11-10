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
using System.Diagnostics;

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class formWifiHistory : MetroFramework.Forms.MetroForm
    {
        public formWifiHistory()
        {
            InitializeComponent();
        }

        private void formWifiHistory_Load(object sender, EventArgs e)
        {
            WIFIHistoryShow();
        }

        private void formWifiHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formDashboard fd = new formDashboard();
            fd.Show();
            this.Hide();
        }




        public void WIFIHistoryShow()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true; // new window open krny s mana kia h
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("netsh wlan show profile key=clear");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine("\n\n\n");
            label1.Text = process.StandardOutput.ReadToEnd();
        }
    }
}
