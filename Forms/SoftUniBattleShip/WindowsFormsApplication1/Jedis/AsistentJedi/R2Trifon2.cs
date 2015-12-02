using System;
using Game.Inerface;
using Jedis;

namespace Game
{
    public class R2Trifon2 : Assistant, IR2Trifon2
    {
        public R2Trifon2(int poits) : base(poits)
        {
        }

        public R2Trifon2() : base()
        {
            this.AssistantJediType = AssistantJediType.R2Trifon2;
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