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

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class Form1 : Form
    {
        // Making Public To Uername For Recalling It To Another Form
        public static string PassingUsername;

        // Make Windows Form Border Radius Curved
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        // Creating Object For Speech Recognization, Speech into text And Greeting Speech After Login

        //SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine src = new SpeechRecognitionEngine();
        Choices clist = new Choices();

        // New SpeechSynthesizer Object For Greeting
        SpeechSynthesizer speechSynthesizerObj;

        public Form1()
        {
            InitializeComponent();
            // Windows Form BorderCurved
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));


            // Speech Recognization
            speechSynthesizerObj = new SpeechSynthesizer();

            // Call The Gretting Method On form Load
            Greeting();
        }

        // Greetings On form Load By Bot
        public void Greeting()
        {
            speechSynthesizerObj.Dispose();
            speechSynthesizerObj = new SpeechSynthesizer();

            foreach (var v in speechSynthesizerObj.GetInstalledVoices().Select(v => v.VoiceInfo))
            {
                Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}", v.Description, v.Gender, v.Age);
            }

            speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

            speechSynthesizerObj.SetOutputToDefaultAudioDevice();


            //Asynchronously speaks the contents present in RichTextBox1
            speechSynthesizerObj.SpeakAsync(@"Hello
                                              Press Mic On The Below Left If You Want To Speak
                                              Or Type The username Or Password To Continue");

            //PromptBuilder builder = new PromptBuilder();
            //builder.AppendText("Welcome To VA Soft Operating System");
            //speechSynthesizerObj.Speak(builder);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Remove The Form Top Most Section
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Foucus On textbox1 On Form Load
            this.ActiveControl = metroTextBox1;
            metroTextBox1.Focus();

            // Hide The label12 Of Greeting
            label12.Visible = false;
        }

        // Shortcut Key Of KeyDown For Textbox1 when Enter Key is Press
        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroTextBox2.Focus();
            }
        }

        // Shortcut Key Of KeyUp For Textbox2 when Up Key is Press
        private void metroTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                metroTextBox1.Focus();
            }
        }

        // Shortcut Key Of KeyDown For Textbox2 when Enter Key is Press
        private void metroTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.Focus();
            }
        }

        // Speech started when The Mic is clicked
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            speechSynthesizerObj.Dispose();
            src.RecognizeAsyncStop();

            formModal nextForm = new formModal();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();


            speechSynthesizerObj = new SpeechSynthesizer();
            foreach (var v in speechSynthesizerObj.GetInstalledVoices().Select(v => v.VoiceInfo))
            {
                Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}", v.Description, v.Gender, v.Age);
            }

            speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);

            speechSynthesizerObj.SetOutputToDefaultAudioDevice();


            //Asynchronously speaks the contents present in RichTextBox1
            speechSynthesizerObj.SpeakAsync(@"Speak Username First");

        }

        // Stop the speech/voice command on click of this mic image
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //src.RecognizeAsyncStop();
            pictureBox1.Visible = false;
            label11.Visible = false;

            pictureBox5.Visible = true;
            speechSynthesizerObj.Dispose();

            if (metroTextBox1.Text == "abc")
            {
                this.ActiveControl = metroTextBox2;
                metroTextBox2.Focus();
            }
        }

        // Login Validation
        public void Login()
        {
            if (metroTextBox1.Text == "abc" && metroTextBox2.Text == "abc")
            {
                // If Username is correct then
                speechSynthesizerObj.Dispose();
                speechSynthesizerObj = new SpeechSynthesizer();

                foreach (var v in speechSynthesizerObj.GetInstalledVoices().Select(v => v.VoiceInfo))
                {
                    Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}", v.Description, v.Gender, v.Age);
                }

                speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);

                speechSynthesizerObj.SetOutputToDefaultAudioDevice();


                //Asynchronously speaks the contents present in RichTextBox1
                speechSynthesizerObj.SpeakAsync(@"Welcome User'" + metroTextBox1.Text + "'");
                formDashboard fd = new formDashboard();
                this.Hide();
                fd.Show();
            }
        }
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "abc")
            {
                // If Username is correct then
                speechSynthesizerObj.Dispose();
                speechSynthesizerObj = new SpeechSynthesizer();

                foreach (var v in speechSynthesizerObj.GetInstalledVoices().Select(v => v.VoiceInfo))
                {
                    Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}", v.Description, v.Gender, v.Age);
                }

                speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);

                speechSynthesizerObj.SetOutputToDefaultAudioDevice();


                //Asynchronously speaks the contents present in RichTextBox1
                speechSynthesizerObj.SpeakAsync(@"Username Is Match");
            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox2.Text == "abc")
            {
                // If Username is correct then
                speechSynthesizerObj.Dispose();
                speechSynthesizerObj = new SpeechSynthesizer();

                foreach (var v in speechSynthesizerObj.GetInstalledVoices().Select(v => v.VoiceInfo))
                {
                    Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}", v.Description, v.Gender, v.Age);
                }

                speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);

                speechSynthesizerObj.SetOutputToDefaultAudioDevice();


                //Asynchronously speaks the contents present in RichTextBox1
                speechSynthesizerObj.SpeakAsync(@"Password Match Successfully");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PassingUsername = metroTextBox1.Text;
            
            Login();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
