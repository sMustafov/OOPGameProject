using System;
using Game.Inerface;
using Jedis;

namespace Game
{
    public class SipiTriBiriO : AssistantPaduin, ISipiTriBitiO
    {
        public SipiTriBiriO(int points) : base(points)
        {
        }

        public SipiTriBiriO() : base()
        {
            this.AssistantPaduinType = AssistantPaduinType.SipiTriBiriO;
        }

        public  int AssistantLives
        {
            get { return this.assistantLives; }
            set { this.assistantLives = 40; }
        }

        public int AssistantAttack
        {
            get { return this.assistantAttack; }
            set { this.assistantAttack = 5; }
        }

        public int AssistantPoints
        {
            get { return this.assistantPoints; }
            set
            { this.assistantPoints += value; }
        }

        public override void Point()
        {
            if (AssistantPoints > AssistantLives)
            {
                Console.WriteLine("CubaEdo is drunk!!!");
            }
        }
    }
}