namespace Jedis
{
    public interface IAsistentsPaduin
    {

        int AsistentPoint { get; } // Damadge който му се нанася

        int AssistentistAttack { get; } //Damadge който нанася 

        int AsistentsLive { get; } // Живота му

        AsistentPaduinType AsistentPaduinType { get; set; }

        void Point();

    }
}