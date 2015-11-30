namespace Jedis.Inerface
{
    public interface IJedi
    {
        int PointsDamadje { get; } //Damadge който му се нанася

        int DemidjeKnolidge { get; } //Damadge който нанася

        int ThePolerOfDrinks { get; } //Живота му

        JediType JediType { get; } //

        void Points();
    }
}