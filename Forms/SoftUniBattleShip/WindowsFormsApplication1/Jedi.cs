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
    public partial class Jedi : Form
    {
        public Jedi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreen ss = new StartingScreen();
            ss.ShowDialog();
            this.Close();
        }

        private void Jedi_Load(object sender, EventArgs e)
        {

        }

        private void AchoButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
