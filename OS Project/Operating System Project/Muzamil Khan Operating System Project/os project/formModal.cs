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
    public partial class formModal : Form
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
        public formModal()
        {
            InitializeComponent();

            LoadAll();
        }

        private void formModal_Load(object sender, EventArgs e)
        {
            // Windows Form BorderCurved
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
            // Remove The Form Top Most Section
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public void LoadAll()
        {
            //pictureBox1.Enabled = true;
            clist.Add(new string[] { "abc", "ahmed", "Welcome", "Thank You" });
            Grammar gr = new Grammar(new GrammarBuilder(clist));


            //Create the spelling dictation grammar.  
            DictationGrammar spellingDictationGrammar =
            new DictationGrammar("grammar:dictation#spelling");
            spellingDictationGrammar.Name = "spelling dictation";
            spellingDictationGrammar.Enabled = true;


            //Create a default dictation grammar.  
            DictationGrammar defaultDictationGrammar = new DictationGrammar();
            defaultDictationGrammar.Name = "default dictation";
            defaultDictationGrammar.Enabled = true;

            //// Adding the Grammer Dictionary
            //Grammar gr = new DictationGrammar();

            try
            {
                src.RequestRecognizerUpdate();
                src.LoadGrammar(gr);
                src.SpeechRecognized += src_SpeechRecognized;
                src.SetInputToDefaultAudioDevice();
                src.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            // Speak The Username First
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
        private void src_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + e.Result.Text.ToString() + Environment.NewLine;
            metroTextBox1.Text = "ahmed";

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

            FaceDetection nextForm = new FaceDetection();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        public void Login()
        {
            if (metroTextBox1.Text == "ahmed")
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
                speechSynthesizerObj.SpeakAsync(@"Face Detection Mode Is On'" + metroTextBox1.Text + "'");

                FaceDetection nextForm = new FaceDetection();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
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

        private void formModal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
