using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IPadaun.IAssistantPaduin;

namespace WindowsFormsApplication1.Paduins.AssistantPaduin
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
        public int AssistantAttack { get; private set; }
        public int AssistantLive { get; private set; }
        public AssistantPaduinType AssistantPaduinType { get; set; }
        public abstract void Point();
    }
}