using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.Hide();
            PlayScreen ps = new PlayScreen();
            ps.ShowDialog();
            this.Close();
        }

        private void StartingScreen_Load(object sender, EventArgs e)
        {

        }

        private void CharacterTypeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseCharacterScreen ccs = new ChooseCharacterScreen();
            ccs.ShowDialog();
            this.Close();
        }

        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructions instructions = new Instructions();
            instructions.ShowDialog();
            this.Close();
        }

        private void ChooseCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseCategoryScreen ccs = new ChooseCategoryScreen();
            ccs.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
