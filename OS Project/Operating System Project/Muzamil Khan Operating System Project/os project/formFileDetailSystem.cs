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
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class formFileDetailSystem : MetroFramework.Forms.MetroForm
    {
        public formFileDetailSystem()
        {
            InitializeComponent();
        }

        private void formFileDetailSystem_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formDashboard fd = new formDashboard();
            fd.Show();
            this.Hide();
        }

        private void formFileDetailSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formDetailsOfCurrentProject fsd = new formDetailsOfCurrentProject();
            fsd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formDirectoryDetailsOfCurrentProject fs = new formDirectoryDetailsOfCurrentProject();
            fs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formSizeOfCurrentProject cs = new formSizeOfCurrentProject();
            cs.Show();
            this.Hide();
        }
    }
}
