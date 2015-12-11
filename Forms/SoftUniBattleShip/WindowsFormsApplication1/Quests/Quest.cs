namespace WindowsFormsApplication1.Quests
{
    using System;

    public class Quest
    {
        public string Question { get; private set ; }

        public string Answer { get; private set ; }

        public QuestionType Type { get; private set; }

        //constructor
        public Quest(string question, string answer, QuestionType type)
        {
            this.Question = question;
            this.Answer = answer;
            this.Type = type;
        }

        /// <summary>
        /// This method checks weather the answer is correct
        /// </summary>
        /// <param name="playerAnswer">Answer to be checked</param>
        /// <returns>True if correct, false if not</returns>
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
