using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Language.V1;
using Google.Cloud.Speech.V1;
using Grpc.Auth;
using Google.Protobuf.Collections;
using NAudio.Mixer;
using FaceRecognition;

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class FaceDetection : MetroFramework.Forms.MetroForm
    {
        // Making Public To Uername For Recalling It To Another Form
        public static string PassingUsername;

        // Creating Object For Speech Recognization, Speech into text And Greeting Speech After Login

        //SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine src = new SpeechRecognitionEngine();
        Choices clist = new Choices();

        // New SpeechSynthesizer Object For Greeting
        SpeechSynthesizer speechSynthesizerObj;

        public FaceDetection()
        {
            InitializeComponent();
        }

        FaceRec facerec = new FaceRec();

        private void formFaceDetection_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formModal fm = new formModal();
            fm.Show();
            this.Hide();
        }

        private void FaceDetection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formAddFace fm = new formAddFace();
            fm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            facerec.isTrained = true;

            if (pictureBox1.Image != null)
            {
                // If Username is correct then
                speechSynthesizerObj = new SpeechSynthesizer();

                foreach (var v in speechSynthesizerObj.GetInstalledVoices().Select(v => v.VoiceInfo))
                {
                    Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}", v.Description, v.Gender, v.Age);
                }

                speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);

                speechSynthesizerObj.SetOutputToDefaultAudioDevice();


                //Asynchronously speaks the contents present in RichTextBox1
                speechSynthesizerObj.SpeakAsync(@"Welcome To VA Software");

                formDashboard nextForm = new formDashboard();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            facerec.openCamera(pictureBox1, pictureBox2);
        }
    }
}
