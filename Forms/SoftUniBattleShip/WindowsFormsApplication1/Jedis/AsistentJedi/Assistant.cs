using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi.IAssistants;

namespace WindowsFormsApplication1.Jedis.AsistentJedi
{
    public abstract class Assistant : IAssistants
    {
        protected int assistantAttack;
        protected int assistantLives;
        protected int assistantPoints;

        protected Assistant(int points)
        {
            this.AssistantPoint = points;
        }

        protected Assistant()
        {
        }

        public virtual int AssistantPoint { get; set; }

        public virtual int AssistantAttack { get; set; }

        public virtual int AssistantLive { get; set; }

        public abstract string CharacterImage { get; set; }

        public AssistantJediType AssistantJediType { get; set; }

        public virtual void Point()
        {
            throw new System.NotImplementedException();
        }
    }
}