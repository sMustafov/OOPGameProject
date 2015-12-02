namespace SoftUniBattleShip.Jedis.AsistentJedi
{
    using Interface;
    using Interface.IJedi.IAssistants;
    
    public class Assistant : IAssistants
    {
        protected int assistantAttack;
        protected int assistantLives;
        protected int assistantPoints;

        protected Assistant(int points)
        {
            AssistantPoints = points;
        }

        protected Assistant()
        {
        }

        public virtual int AssistantPoints { get; set; }

        public virtual int AssistantAttack { get; set; }

        public virtual int AssistantLives { get; set; }

        public AssistantJediType AssistantJediType { get; set; }

        public virtual void Point()
        {
            throw new System.NotImplementedException();
        }
    }
}