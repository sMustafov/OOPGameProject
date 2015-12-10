using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Question : Form
    {
        public static int FinalAnswer;
        private int answer;
        private Question question;
        private PlayScreen pl;

        public Question()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Question_Load(object sender, EventArgs e)
        {

        }

        private void TrueButton_CheckedChanged(object sender, EventArgs e)
        {
            answer = 1;
        }

        private void FalseButton_CheckedChanged(object sender, EventArgs e)
        {
            answer = 2;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FinalAnswer = answer;
            this.Close();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answer = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            answer = 4;
        }
    }
}
