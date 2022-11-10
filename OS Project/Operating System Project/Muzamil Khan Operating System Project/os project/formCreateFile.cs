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
using System.IO;

namespace Muzamil_Khan_Operating_System_Project
{
    public partial class formCreateFile : MetroFramework.Forms.MetroForm
    {
        // Creating Object For Speech Recognization, Speech into text And Greeting Speech After Login

        //SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine src = new SpeechRecognitionEngine();
        Choices clist = new Choices();

        // New SpeechSynthesizer Object For Greeting
        SpeechSynthesizer speechSynthesizerObj;

        public formCreateFile()
        {
            InitializeComponent();
        }
        private void formCreateFile_Load(object sender, EventArgs e)
        {
            // Remove The Form Top Most Section
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        public void ReadFile()
        {
            if (richTextBox1.Text !="")
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
                speechSynthesizerObj.SpeakAsync(@"Reading Mode Is On '" + richTextBox1.Text + "'");
            }
        }

        // Textchange Text
        public void ReadRunTimeText()
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
            speechSynthesizerObj.SpeakAsync(richTextBox2.Text);
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    TextWriter txt = new StreamWriter(@"C:\VAFolder.txt");
        //    txt.Write(textBox1.Text);
        //    txt.Close();

        //    MessageBox.Show("File Save Sucessfully", "VA Create File", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    formDashboard fd = new formDashboard();
        //    fd.Show();
        //    this.Hide();
        //}

        public void NotepadFileSave()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"C:\Users\Dw\Desktop\Operating System Project\Muzamil Khan Operating System Project\Notepad Files";
            save.Filter = "Text Files (*.txt)|*.txt";
            save.DefaultExt = ".txt";

            DialogResult result = save.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (StreamWriter SW = new StreamWriter(save.FileName))
                {
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
        }
        public void WordFileSave()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"C:\Users\Dw\Desktop\Operating System Project\Muzamil Khan Operating System Project\Word File";
            save.Filter = "Text Files (*.doc)|*.doc";
            save.DefaultExt = ".doc";

            DialogResult result = save.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (StreamWriter SW = new StreamWriter(save.FileName))
                {
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
        }
        public void PDFFiles()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"C:\Users\Dw\Desktop\Operating System Project\Muzamil Khan Operating System Project\PDF Files";
            save.Filter = "Text Files (*.pdf)|*.pdf";
            save.DefaultExt = ".doc";

            DialogResult result = save.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (StreamWriter SW = new StreamWriter(save.FileName))
                {
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NotepadFileSave();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WordFileSave();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PDFFiles();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog opentext = new OpenFileDialog();
            if (opentext.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = opentext.FileName;
                richTextBox1.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            ReadFile();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            ReadRunTimeText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formCreateFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formDashboard fd = new formDashboard();
            this.Hide();
            fd.Show();
        }
    }
}