using Game.Inerface;

namespace Jedis
{
    public interface IAssistants
    {
        int AssistantPoint { get; } // Damage който му се нанася

        int AssistantAttack { get; } //Damage който нанася 

        int AssistantLive { get; } // Живота му

        AssistantJediType AssistantJediType { get; set; }

        void Point();
    }
}