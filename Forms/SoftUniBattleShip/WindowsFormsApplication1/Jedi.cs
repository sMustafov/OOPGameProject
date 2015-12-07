using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Jedi : Form
    {
        public Jedi()
        {
            InitializeComponent();
        }

        private int Character = 1;
        private int AssistantCharacter = 1;
        public static int FinalCharacter = 1;
        public static int FinalAssistantCharacter = 1;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Character = 1;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinalCharacter = Character;
            FinalAssistantCharacter = AssistantCharacter;
            ChooseCharacterScreen ss = new ChooseCharacterScreen();
            ss.ShowDialog();
            this.Close();
        }

        private void Jedi_Load(object sender, EventArgs e)
        {
            
        }

        private void AchoButton_CheckedChanged(object sender, EventArgs e)
        {
            Character = 2;
        }

        private void RoyalButton_CheckedChanged(object sender, EventArgs e)
        {
            Character = 3;
        }

        private void NaskoButton_CheckedChanged(object sender, EventArgs e)
        {
            Character = 4;
        }

        private void EdoButton_CheckedChanged(object sender, EventArgs e)
        {
            AssistantCharacter = 1;
        }

        private void TrigonButton_CheckedChanged(object sender, EventArgs e)
        {
            AssistantCharacter = 2;
        }

        private void BackButton(object sender, EventArgs e)
        {
            this.Hide();
            FinalCharacter = Character;
            FinalAssistantCharacter = AssistantCharacter;
            ChooseCharacterScreen ccs = new ChooseCharacterScreen();
            ccs.ShowDialog();
            this.Close();
        }
    }
}
