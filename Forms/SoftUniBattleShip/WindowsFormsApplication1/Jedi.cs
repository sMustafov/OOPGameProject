using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Jedis.Masters;

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
            this.Character = 1;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Hide();
            FinalCharacter = this.Character;
            FinalAssistantCharacter = this.AssistantCharacter;
            ChooseCharacterScreen ss = new ChooseCharacterScreen();
            ss.ShowDialog();
            Close();
        }

        private void Jedi_Load(object sender, EventArgs e)
        {
            
        }

        private void AchoButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Character = 2;
        }

        private void RoyalButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Character = 3;
        }

        private void NaskoButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Character = 4;
        }

        private void EdoButton_CheckedChanged(object sender, EventArgs e)
        {
            this.AssistantCharacter = 1;
        }

        private void TrigonButton_CheckedChanged(object sender, EventArgs e)
        {
            this.AssistantCharacter = 2;
        }

        private void BackButton(object sender, EventArgs e)
        {
            Hide();
            FinalCharacter = this.Character;
            FinalAssistantCharacter = this.AssistantCharacter;
            ChooseCharacterScreen ccs = new ChooseCharacterScreen();
            ccs.ShowDialog();
            Close();
        }

        public static implicit operator Jedi(JoNakov v)
        {
            throw new NotImplementedException();
        }
    }
}
