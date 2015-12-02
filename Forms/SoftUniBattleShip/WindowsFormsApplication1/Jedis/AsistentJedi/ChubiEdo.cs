using System;
using Jedis;

namespace Game
{
    public class ChubiEdo : Assistant, IChubiEdo
    {
        public ChubiEdo(int poits) : base(poits)
        {
        }

        public ChubiEdo() : base()
        {
            this.AssistantJediType = AssistantJediType.ChubiEdo;
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