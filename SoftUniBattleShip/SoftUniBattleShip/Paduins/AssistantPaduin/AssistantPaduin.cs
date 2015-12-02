using Game.Inerface;
using Jedis;

namespace Game
{
    public abstract class AssistantPaduin : IAssistantPaduin
    {
        protected int assistantAttack;
        protected int assistantLives;
        protected int assistantPoints;

        protected AssistantPaduin(int assistantAtttack)
        {
            this.AssistantAttack = assistantAtttack;
        }

        protected AssistantPaduin()
        {
        }

        public int AssistantPoint { get; private set; }
        public abstract int AssistantAttack { get; set; }
        public int AssistantLive { get; private set; }
        public AssistantPaduinType AssistantPaduinType { get; set; }
        public abstract void Point();
    }
}