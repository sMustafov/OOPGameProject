

namespace Jedis
{
    public class JediKnight : Jedi.Jedi, IJediKnight
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