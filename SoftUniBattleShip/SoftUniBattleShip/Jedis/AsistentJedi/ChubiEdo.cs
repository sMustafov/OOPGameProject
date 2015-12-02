namespace SoftUniBattleShip.Jedis.AsistentJedi
{
    using System;

    using Interface;
    using Interface.IJedi.IAssistants;

    public class ChubiEdo : Assistant, IChubiEdo
    {
        public ChubiEdo(int poits) : base(poits)
        {
        }

        public ChubiEdo() : base()
        {
            this.AssistantJediType = AssistantJediType.ChubiEdo;
        }

        public override int AssistantLives
        {
            get { return this.assistantLives; }
            set { this.assistantLives = 40; }
        }

        public override int  AssistantAttack
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
                Console.WriteLine("ChubiEdo is drunk!!!");
            }
        }
    }
}