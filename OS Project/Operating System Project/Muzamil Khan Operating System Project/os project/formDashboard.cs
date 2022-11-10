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
    public partial class formDashboard : MetroFramework.Forms.MetroForm
    {
        //SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine src = new SpeechRecognitionEngine();
        Choices clist = new Choices();

        // New SpeechSynthesizer Object For Greeting
        SpeechSynthesizer speechSynthesizerObj;

        public formDashboard()
        {
            InitializeComponent();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            metroLabel21.Text = Form1.PassingUsername;
            metroLabel21.Text = formModal.PassingUsername;

            // Speech Recognization
            speechSynthesizerObj = new SpeechSynthesizer();

            label11.Visible = false;

            VoiceCommand();
        }

        public void VoiceCommand()
        {
            speechSynthesizerObj.Dispose();
            src.RecognizeAsyncStop();
            speechSynthesizerObj = new SpeechSynthesizer();
            foreach (var v in speechSynthesizerObj.GetInstalledVoices().Select(v => v.VoiceInfo))
            {
                Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}", v.Description, v.Gender, v.Age);
            }
            speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            speechSynthesizerObj.SetOutputToDefaultAudioDevice();
            //Asynchronously speaks the contents present in RichTextBox1
            speechSynthesizerObj.SpeakAsync(@"");
            //pictureBox1.Enabled = true;
            clist.Add(new string[] { "Create File", "File Explorer", "Web Browser", "Files", "File DT", "Web Browser", "Add Face", "Processes" });
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

            //// Speak The Username First
            //speechSynthesizerObj = new SpeechSynthesizer();

            //foreach (var v in speechSynthesizerObj.GetInstalledVoices().Select(v => v.VoiceInfo))
            //{
            //    Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}", v.Description, v.Gender, v.Age);
            //}

            //speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);

            //speechSynthesizerObj.SetOutputToDefaultAudioDevice();

            ////Asynchronously speaks the contents present in RichTextBox1
            //speechSynthesizerObj.SpeakAsync(@"Speak Username First");
        }
        private void src_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
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


            string files = "Files";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCreateFile fd = new formCreateFile();
            this.Hide();
            fd.Show();
        }
        public void Introduction()
        {
            label11.Visible = true;
            speechSynthesizerObj.Dispose();
            src.RecognizeAsyncStop();
            speechSynthesizerObj = new SpeechSynthesizer();
            foreach (var v in speechSynthesizerObj.GetInstalledVoices().Select(v => v.VoiceInfo))
            {
                Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}", v.Description, v.Gender, v.Age);
            }
            speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            speechSynthesizerObj.SetOutputToDefaultAudioDevice();
            //Asynchronously speaks the contents present in RichTextBox1
            speechSynthesizerObj.SpeakAsync(@"Speak Any Operation '" + Form1.PassingUsername + "' To Continue");
            //pictureBox1.Enabled = true;
            clist.Add(new string[] { "Create File", "microsoft", "Welcome", "Thank You" });
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
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            speechSynthesizerObj.Dispose();
            src.UnloadAllGrammars();
            src.RecognizeAsyncStop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Introduction();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formFileExplorer fc = new formFileExplorer();
            this.Hide();
            fc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formFileBrowser fb = new formFileBrowser();
            this.Hide();
            fb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formCPUProcessingSpeed CPS = new formCPUProcessingSpeed();
            this.Hide();
            CPS.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            formFileDetailSystem fs = new formFileDetailSystem();
            fs.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formProcess fp = new formProcess();
            fp.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formWifiHistory wf = new formWifiHistory();
            wf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formAddFace fd = new formAddFace();
            fd.Show();
            this.Hide();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            WIFIProperties wh = new WIFIProperties();
            wh.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formWebBrowser wf = new formWebBrowser();
            wf.Show();
            this.Hide();
        }

    }
}
