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
    public partial class formCPUProcessingSpeed : MetroFramework.Forms.MetroForm
    {
        public formCPUProcessingSpeed()
        {
            InitializeComponent();
        }

        private void formCPUProcessingSpeed_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            //Set value to cpu and ram
            metroProgressBar1.Value = (int)fcpu;
            metroProgressBar2.Value = (int)fram;
            //Update value to cpu and ram label
            metroLabel1.Text = string.Format("{0:0.00}%", fcpu);
            metroLabel2.Text = string.Format("{0:0.00}%", fram);
            //Draw cpu and ram chart
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formCPUProcessingSpeed_FormClosing(object sender, FormClosingEventArgs e)
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
