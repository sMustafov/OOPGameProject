using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Paduin : Form
    {
        private int paduinCharacter = 1;
        private int paduinAssistant = 1;
        public static int FinalPaduinCharacter = 1;
        public static int FinalPaduin = 1;

        public Paduin()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreen ss = new StartingScreen();
            FinalPaduinCharacter = paduinCharacter;
            ss.ShowDialog();
            this.Close();
        }

        private void PaduinLabel_Click(object sender, EventArgs e)
        {

        }

        private void AssistantLabel_Click(object sender, EventArgs e)
        {

        }

        private void SevginButton_CheckedChanged(object sender, EventArgs e)
        {
            paduinCharacter = 1;
        }

        private void YanchoButton_CheckedChanged(object sender, EventArgs e)
        {
            paduinCharacter = 2;
        }

        private void SashoButton_CheckedChanged(object sender, EventArgs e)
        {
            paduinCharacter = 3;
        }

        private void JanButton_CheckedChanged(object sender, EventArgs e)
        {
            paduinCharacter = 4;
        }

        private void Paduin_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FuglemanButton_CheckedChanged(object sender, EventArgs e)
        {
            paduinAssistant = 1;
        }

        private void TriBiriButton_CheckedChanged(object sender, EventArgs e)
        {
            paduinAssistant = 2;
        }
    }
}
