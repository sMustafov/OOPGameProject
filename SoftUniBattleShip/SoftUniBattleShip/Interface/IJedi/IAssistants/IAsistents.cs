using Game.Inerface;

namespace Jedis
{
    public interface IAssistants
    {
        int AssistantPoints { get; } // Damage който му се нанася

        int AssistantAttack { get; } //Damage който нанася 

        int AssistantLives { get; } // Живота му

        AssistantJediType AssistantJediType { get; set; }

        void Point();
    }
}