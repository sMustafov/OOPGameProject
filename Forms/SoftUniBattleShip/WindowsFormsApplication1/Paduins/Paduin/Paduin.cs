using Jedis;

namespace Game
{
    public abstract class Paduin : IPaduin
    {
        protected int paduinPower;
        protected int beerPerSecond;
        protected int pointKnowledge;
        protected AssistantPaduin assistantPaduin;

        protected Paduin(int pointKnowledge, AssistantPaduin assistantPaduin)
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

        public AssistantPaduin AssistantPaduin { get; set; }

        public abstract void KnowledgeCalculator();
    }
}