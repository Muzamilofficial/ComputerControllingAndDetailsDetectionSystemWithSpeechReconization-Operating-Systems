using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class WIFIProperties : MetroFramework.Forms.MetroForm
    {
        public WIFIProperties()
        {
            InitializeComponent();
        }

        private void formWIFIProperties_Load(object sender, EventArgs e)
        {
            LoadAll();
        }
        public void LoadAll()
        {
            showConnectedId();
        }
        // Show SSID and Signal Strength
        private void showConnectedId()
        {
            Process p = new Process();
            p.StartInfo.FileName = "netsh.exe";
            p.StartInfo.Arguments = "wlan show interfaces";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            string s = p.StandardOutput.ReadToEnd();
            string s1 = s.Substring(s.IndexOf("SSID"));
            s1 = s1.Substring(s1.IndexOf(":"));
            s1 = s1.Substring(2, s1.IndexOf("\n")).Trim();

            string s2 = s.Substring(s.IndexOf("Signal"));
            s2 = s2.Substring(s2.IndexOf(":"));
            s2 = s2.Substring(2, s2.IndexOf("\n")).Trim();

            label1.Text = "WIFI connected to " + s1 + "  " + s2;
            p.WaitForExit();
        }

        private void WIFIProperties_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formDashboard fd = new formDashboard();
            fd.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
