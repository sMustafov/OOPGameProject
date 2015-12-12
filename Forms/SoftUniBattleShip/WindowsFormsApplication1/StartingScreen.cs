using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class StartingScreen : Form
    {
        public StartingScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            PlayScreen ps = new PlayScreen();
            ps.ShowDialog();
            Close();
        }

        private void StartingScreen_Load(object sender, EventArgs e)
        {

        }

        private void CharacterTypeButton_Click(object sender, EventArgs e)
        {
            Hide();
            ChooseCharacterScreen ccs = new ChooseCharacterScreen();
            ccs.ShowDialog();
            Close();
        }

        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Instructions instructions = new Instructions();
            instructions.ShowDialog();
            Close();
        }

        private void ChooseCategory_Click(object sender, EventArgs e)
        {
            Hide();
            ChooseCategoryScreen ccs = new ChooseCategoryScreen();
            ccs.ShowDialog();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
