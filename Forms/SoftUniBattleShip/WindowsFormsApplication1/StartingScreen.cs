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

        }

        private void StartingScreen_Load(object sender, EventArgs e)
        {

        }

        private void CharacterTypeButton_Click(object sender, EventArgs e)
        {
            ChooseCharacterScreen ccs = new ChooseCharacterScreen();
            ccs.Show();
        }
    }
}
