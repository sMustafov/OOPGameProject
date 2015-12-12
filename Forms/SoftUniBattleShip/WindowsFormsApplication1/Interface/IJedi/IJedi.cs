namespace WindowsFormsApplication1.Interface.IJedi
{
    public interface IJedi
    {
        int PointsDamage { get; set; } //Damage който му се нанася

        int KnowledgeDamage { get; set; } //Damadge който нанася

        int ThePolerOfDrinks { get; set; } //Живота му

        JediType JediType { get; set; } //

        string CharacterImage { get; set; }

        void Points();
    }
}