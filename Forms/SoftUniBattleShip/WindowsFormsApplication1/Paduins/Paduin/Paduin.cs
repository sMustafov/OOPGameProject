using WindowsFormsApplication1.Interface.IPadaun.IPaduinStudents;

namespace WindowsFormsApplication1.Paduins.Paduin
{
    public abstract class Paduin : IPaduin
    {
        protected int paduinPower;
        protected int beerPerSecond;
        protected int pointKnowledge;
        protected AssistantPaduin.AssistantPaduin assistantPaduin;

        protected Paduin(int pointKnowledge, AssistantPaduin.AssistantPaduin assistantPaduin)
        {
            this.PointKnowledge = pointKnowledge;
            this.AssistantPaduin = assistantPaduin;
        }

        protected Paduin()
        {
        }

        public string NickName { get; set; }

        public int PointKnowledge { get; set; }

        public int PaduinPower { get; set; }

        public int BeerPerSecond { get; set; }

        public abstract string CharacterImage { get; set; }

        public PaduinType PaduinType { get; set; }

        public AssistantPaduin.AssistantPaduin AssistantPaduin { get; set; }

        public abstract void KnowledgeCalculator();
    }
}