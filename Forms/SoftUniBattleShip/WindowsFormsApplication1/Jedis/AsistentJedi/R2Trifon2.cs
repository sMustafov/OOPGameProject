using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi.IAssistants;

namespace WindowsFormsApplication1.Jedis.AsistentJedi
{
    public class R2Trifon2 : Assistant, IR2Trifon2
    {
        private string characterImage = @"..\..\Resources\trifon.jpg";

        public R2Trifon2(int poits) : base(poits)
        {
        }

        public R2Trifon2() : base()
        {
            this.AssistantJediType = AssistantJediType.R2Trifon2;
        }
        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
        }
        public override int AssistantLive
        {
            get { return this.assistantLives; }
            set { this.assistantLives = 40; }
        }

        public override int AssistantAttack
        {
            get { return this.assistantAttack; }
            set { this.assistantAttack = 5; }
        }

        public override int AssistantPoint
        {
            get { return this.assistantPoints; }
            set{ this.assistantPoints += value; }
        }

        public override void Point()
        {
            if (AssistantPoint > AssistantLive)
            {
                Console.WriteLine("R2Trifon2 is drunk!!!");
            }
        }
    }
}