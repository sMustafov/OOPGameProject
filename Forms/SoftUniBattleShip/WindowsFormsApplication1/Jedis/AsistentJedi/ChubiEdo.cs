using System;
using Jedis;

namespace Game
{
    public class ChubiEdo : Assistant, IChubiEdo
    {
        private string characterImage = @"C:\Users\pc1\Desktop\OOPGameProject\OOPGameProject\Forms\SoftUniBattleShip\WindowsFormsApplication1\Resources\edo.jpg";

        public ChubiEdo(int poits) : base(poits)
        {
        }

        public ChubiEdo() : base()
        {
            this.AssistantJediType = AssistantJediType.ChubiEdo;
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

        public int AssistantAttack
        {
            get { return this.assistantAttack; }
            set { this.assistantAttack = 5; }
        }

        public override int AssistantPoint
        {
            get { return this.assistantPoints; }
            set
            { this.assistantPoints += value; }
        }

        public override void Point()
        {
            if (AssistantPoint > AssistantLive)
            {
                Console.WriteLine("ChubiEdo is drunk!!!");
            }
        }
    }
}