namespace WindowsFormsApplication1.Interface.IJedi
{
    public interface IJedi
    {
        string NickName { get; set; }

        int PointsDamage { get; } //Damage който му се нанася

        int KnowledgeDamage { get; } //Damadge който нанася

        int ThePolerOfDrinks { get; } //Живота му

        JediType JediType { get; } //

        string CharacterImage { get; set; }

        void Points();
    }
}