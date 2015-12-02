using System;
using Jedis;

namespace Game
{
    public class SashoFett : Paduin, ISashoFett
    {
        public SashoFett(int pointKnowledge, AssistantPaduin assistantPaduin) 
            : base(pointKnowledge, assistantPaduin)
        {

        }

        public SashoFett() : base()
        {
            this.PaduinType = PaduinType.SashoFett;
        }

        public int PointKnowledge1
        {
            get { return this.pointKnowledge; }
            set { this.pointKnowledge += value; }
        }

        public override int PaduinPower
        {
            get { return this.paduinPower; }
            set { this.paduinPower = 50; }
        }

        public int BeerPerSecound
        {
            get { return this.beerPerSecond; }
            set { this.beerPerSecond = 3; }
        }

        public override void KnowledgeCalculator()
        {
            if (PaduinPower < PointKnowledge)
            {
                Console.WriteLine("Paduin have knowledge");
            }
        }
    }
}