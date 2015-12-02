using SoftUniBattleShip.Interface;
using SoftUniBattleShip.Interface.IPadaun.IPaduinStudents;

namespace SoftUniBattleShip.Paduins.Paduin
{
    using System;
    
    using SoftUniBattleShip;
    using Jedis;
   
    internal class Karnobatman : Paduin, IKarnobatmanFromKranobasterdam
    {
        public Karnobatman(int pointKnowledge, AssistantPaduin.AssistantPaduin assistantPaduin) 
            : base(pointKnowledge, assistantPaduin)
        {

        }

        public Karnobatman() : base()
        {
            this.PaduinType = PaduinType.Karnotman;
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