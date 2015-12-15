namespace WindowsFormsApplication1
{
    using System;
    using System.Windows.Forms;

    using Quests;

    public partial class Question : Form
    {
        public static int FinalAnswer; //used smwhere else and cannot be converted to string for checking answer
                                       //makes it too complicated... introducing answerAsString for the check

        private int answer;
        private Quest quest;
        private string answerAsString; //used to check playerAnswer - questionAnswer

        public Question()
        {
            InitializeComponent();
        }

        private void Question_Load(object sender, EventArgs e)
        {
            quest = QuestFactory.GenerateQuestOnCategory();
            this.questionLabel.Text = quest.ToString();
        }

        private void TrueButton_CheckedChanged(object sender, EventArgs e)
        {
            this.answer = 1;
            this.answerAsString = "true";
        }

        private void FalseButton_CheckedChanged(object sender, EventArgs e)
        {
            this.answer = 2;
            this.answerAsString = "false";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.answer = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.answer = 4;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FinalAnswer = this.answer;

            //checks the anwer of the question
            if (QuestFactory.CheckAnswer(answerAsString, quest.Answer))
            {
                MessageBox.Show("CORRECT!"); //logic if correct
            }
            else
            {
                MessageBox.Show("NOT CORRECT"); //logic if not correct
            }
            
            Close();

        }

    }
}
