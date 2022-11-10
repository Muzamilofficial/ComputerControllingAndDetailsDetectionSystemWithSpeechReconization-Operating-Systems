using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class formAddFace : MetroFramework.Forms.MetroForm
    {
        public formAddFace()
        {
            InitializeComponent();
        }

        FaceRec facerec = new FaceRec();

        private void formAddFace_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formAddFace_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formDashboard fd = new formDashboard();
            fd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            facerec.Save_IMAGE(@"");

            MessageBox.Show("Picture Saved Sucessfully", "VA Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            facerec.openCamera(pictureBox1, pictureBox2);
        }
    }
}
