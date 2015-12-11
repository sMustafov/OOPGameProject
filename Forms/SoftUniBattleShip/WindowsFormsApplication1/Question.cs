using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Quests;

namespace WindowsFormsApplication1
{
    public partial class Question : Form
    {
        public static int PlayerAnswer;
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

        //Load Question when get hit
        private void Question_Load(object sender, EventArgs e)
        {   
            label1.Text = LoadQuest(ChooseCategoryScreen.FinalCategory).ToString();
        }

        /// <summary>
        /// This method loads a question from specific category
        /// </summary>
        /// <param name="category">Picked category</param>
        /// <returns>Question</returns>
        private static Quest LoadQuest(int category)
        {
            Quest quest = null;
            switch (category)
            {
                case 1:
                    quest = QuestFactory.GenerateQuest(QuestionType.Cs);
                    break;
                case 2:
                    quest = QuestFactory.GenerateQuest(QuestionType.Java);
                    break;
                case 3:
                    quest = QuestFactory.GenerateQuest(QuestionType.Cpp);
                    break;
                case 4:
                    quest = QuestFactory.GenerateQuest(QuestionType.Oop);
                    break;
            }
            return quest;
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
            PlayerAnswer = answer;
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
