using System;
using WindowsFormsApplication1.Interface.IPadaun.IPaduinStudents;

namespace WindowsFormsApplication1.Paduins.Paduin
{
    internal class Karnobatman : Paduin, IKarnobatmanFromKranobasterdam
    {
        private string characterImage = @"..\..\Resources\Qncho.png";

        public Karnobatman(int pointKnowledge, AssistantPaduin.AssistantPaduin assistantPaduin) 
            : base(pointKnowledge, assistantPaduin)
        {

        }

        public Karnobatman() : base()
        {
            this.PaduinType = PaduinType.Karnotman;
        }
        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
        }

        public int PointKnowledge1
        {
            get { return this.pointKnowledge; }
            set { this.pointKnowledge += value; }
        }

        public int PaduinPower
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