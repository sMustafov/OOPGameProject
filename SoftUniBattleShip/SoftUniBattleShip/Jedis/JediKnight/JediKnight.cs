

namespace Jedis
{
    public class JediKnight : Jedi.Jedi, IJediKnight
    {
     
        protected int damadgeKnolidgh;
        protected int thePower;
        protected int point;

        public JediKnight(int points, Asistents asistent) : base(points, asistent)
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