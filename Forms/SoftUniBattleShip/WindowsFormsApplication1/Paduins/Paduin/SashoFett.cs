using System;
using WindowsFormsApplication1.Interface.IPadaun.IPaduinStudents;

namespace WindowsFormsApplication1.Paduins.Paduin
{
    public class SashoFett : Paduin, ISashoFett
    {
        private string characterImage = @"..\..\Resources\Sasho.png";

        public SashoFett(int pointKnowledge, AssistantPaduin.AssistantPaduin assistantPaduin) 
            : base(pointKnowledge, assistantPaduin)
        {

        }

        public SashoFett()
        {
            this.PaduinType = PaduinType.SashoFett;
        }

        public override string CharacterImage
        {
            get { return this.characterImage; }
            protected set { this.characterImage = value; }
        }
        public int PointKnowledge1
        {
            get { return this.pointKnowledge; }
            set { this.pointKnowledge += value; }
        }

        public new int PaduinPower
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