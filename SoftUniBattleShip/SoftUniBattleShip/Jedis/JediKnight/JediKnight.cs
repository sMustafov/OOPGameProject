namespace SoftUniBattleShip.Jedis.JediKnight
{
    using Interface.IJedi.IJediKnight;
    using AsistentJedi;

    public class JediKnight : Jedi, IJediKnight
    {
     
        protected int knowledgeDamage;
        protected int thePower;
        protected int points;

        public JediKnight(int points, Assistant assistant) : base(points, assistant)
        {
            
        }

        public JediKnight():base()
        {
        }

        public override void Points()
        {
            throw new System.NotImplementedException();
        }
    }
}