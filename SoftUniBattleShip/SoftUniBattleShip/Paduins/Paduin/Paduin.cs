using SoftUniBattleShip.Interface;
using SoftUniBattleShip.Interface.IPadaun.IPaduinStudents;

namespace SoftUniBattleShip.Paduins.Paduin
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

        public abstract int PaduinPower { get; set; }

        public int BeerPerSecond { get; set; }

        public PaduinType PaduinType { get; set; }

        public AssistantPaduin.AssistantPaduin AssistantPaduin { get; set; }

        public abstract void KnowledgeCalculator();
    }
}