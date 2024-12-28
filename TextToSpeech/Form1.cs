using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SpeakButton_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer ab = new SpeechSynthesizer();
            ab.Rate = SpeedTrackBar.Value;
            ab.Volume = SoundTrackBar.Value;
            if(PersonComboBox.Text=="Male")
            {
                ab.SelectVoiceByHints(VoiceGender.Male);
            }
            else
            {
                ab.SelectVoiceByHints(VoiceGender.Female);
            }
            ab.Speak(textBox1.Text);
        }
    }
}
