namespace WindowsFormsApplication1.Quests
{
    using System;

    public class Quest
    {

        public string Question { get; set; }

        public string Answer { get; set; }

        public QuestionType Type { get; set; }

        //constructor
        public Quest(string question, string answer, QuestionType type)
        {
            this.Question = question;
            this.Answer = answer;
            this.Type = type;
        }

        public bool IsAnswerCorrect(string playerAnswer)
        {
            return String.Compare(playerAnswer, this.Answer, StringComparison.OrdinalIgnoreCase) == 0;
        }

        public override string ToString()
        {
            return this.Question;
        }
    }
}
