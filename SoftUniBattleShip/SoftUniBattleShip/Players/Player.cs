namespace SoftUniBattleShip.Players
{
    public class Player
    {
        private string userName;
        private int points;
        private int damage;

        public Player(string userName, int points, int damage)
        {
            this.UserName = userName;
            this.Points = points;
            this.Damage = damage;
        }

        public string UserName { get; set; }

        public int Points { get; set; }

        public int Damage { get; set; }
    }
}