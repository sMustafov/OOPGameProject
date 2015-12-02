namespace SoftUniBattleShip.Jedis.AsistentJedi
{
    using System;

    using Interface.IJedi.IAssistants;
    using Interface;
    
    public class R2Trifon2 : Assistant, IR2Trifon2
    {
        public R2Trifon2(int poits) : base(poits)
        {
        }

        public R2Trifon2() : base()
        {
            this.AssistantJediType = AssistantJediType.R2Trifon2;
        }

        public override int AssistantLives
        {
            get { return this.assistantLives; }
            set { this.assistantLives = 40; }
        }

        public override int AssistantAttack
        {
            get { return this.assistantAttack; }
            set { this.assistantAttack = 5; }
        }

        public override int AssistantPoints
        {
            get { return this.assistantPoints; }
            set
            { this.assistantPoints += value; }
        }

        public override void Point()
        {
            if (AssistantPoints > AssistantLives)
            {
                Console.WriteLine("R2Trifon2 is drunk!!!");
            }
        }
    }
}