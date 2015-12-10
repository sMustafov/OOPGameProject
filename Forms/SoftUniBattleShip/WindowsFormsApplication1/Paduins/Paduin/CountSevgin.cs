using System;
using WindowsFormsApplication1.Interface.IPadaun.IPaduinStudents;

namespace WindowsFormsApplication1.Paduins.Paduin
{
    public class CountSevgin : Paduin,ICountSevgin
    {
        private string characterImage = @"..\..\Resources\Sevgin.png";

        public CountSevgin(int pointKnowledge, AssistantPaduin.AssistantPaduin asistensPaduin) 
            : base(pointKnowledge, asistensPaduin)
        {

        }

        public CountSevgin() : base()
        {
            this.PaduinType = PaduinType.CountSevgin;
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