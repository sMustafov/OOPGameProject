using Game.Inerface;

namespace Jedis
{
    public interface IAsistents
    {
        int AsistentPoint { get; } // Damadge който му се нанася

        int AssistentistAttack { get; } //Damadge който нанася 

        int AsistentsLive { get; } // Живота му

        AsistentJediType AsistentJediType { get; set; }

        void Point();
    }
}