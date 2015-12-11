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

        private void Question_Load(object sender, EventArgs e)
        {
            //using Quest/ QuestFactory
            Quest quest = null;
            if (ChooseCategoryScreen.FinalCategory == 1)
            {
               quest = QuestFactory.GenerateQuest(QuestionType.Cs);
            }
            else if (ChooseCategoryScreen.FinalCategory == 2)
            {
                quest = QuestFactory.GenerateQuest(QuestionType.Java);
            }
            else if (ChooseCategoryScreen.FinalCategory == 3)
            {
                quest = QuestFactory.GenerateQuest(QuestionType.Cpp);
            }
            else if (ChooseCategoryScreen.FinalCategory == 4)
            {
                quest = QuestFactory.GenerateQuest(QuestionType.Oop);
            }
            //show quest
            label1.Text = quest.ToString();
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
