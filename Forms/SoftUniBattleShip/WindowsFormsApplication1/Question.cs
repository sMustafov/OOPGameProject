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
            Random random = new Random();
            int randNum = random.Next(1, 5);
            string question = null;
            
            //if (ChooseCategoryScreen.FinalCategory == 1)
            //{
            //    question = JediQuest.cShrap(randNum);
            //}
            //else if (ChooseCategoryScreen.FinalCategory == 2)
            //{
            //    question = JediQuest.Java(randNum);
            //}
            //else if (ChooseCategoryScreen.FinalCategory == 4)
            //{
            //    question = JediQuest.OOP(randNum);
            //}
            //else if (ChooseCategoryScreen.FinalCategory == 3)
            //{
            //    question = JediQuest.cPlusPlus(randNum);
            //}

            this.label1.Text = question;
        }

        private void TrueButton_CheckedChanged(object sender, EventArgs e)
        {
            this.answer = 1;
        }

        private void FalseButton_CheckedChanged(object sender, EventArgs e)
        {
            this.answer = 2;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FinalAnswer = this.answer;
            Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.answer = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.answer = 4;
        }
    }
}
