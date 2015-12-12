using WindowsFormsApplication1.Interface.IPadaun.IPaduinStudents;

namespace WindowsFormsApplication1.Paduins.Paduin
{
    public abstract class Paduin : IPaduin
    {
        protected int paduinPower;
        protected int beerPerSecond;
        protected int pointKnowledge;
        protected AssistantPaduin.AssistantPaduin assistantPaduin;

        protected Paduin()
        {
        }

        public abstract int PointKnowledge { get; set; }

        public abstract int PaduinPower { get; set; }

        public abstract int BeerPerSecond { get; set; }

        public abstract string CharacterImage { get; set; }

        public abstract PaduinType PaduinType { get; set; }

        public abstract AssistantPaduin.AssistantPaduin AssistantPaduin { get; set; }

        public abstract void KnowledgeCalculator();
    }
}