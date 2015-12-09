using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ChooseCategoryScreen : Form
    {
        private int Category = 1;
        public static int FinalCategory = 1;

        public ChooseCategoryScreen()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Category = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Category = 2;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreen ss = new StartingScreen();
            FinalCategory = Category;
            ss.ShowDialog();
            this.Close();
        }

        private void ChooseCategoryScreen_Load(object sender, EventArgs e)
        {

        }

        private void CPPButton_CheckedChanged(object sender, EventArgs e)
        {
            Category = 3;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Category = 4;
        }
    }
}
