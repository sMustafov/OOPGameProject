namespace Jedis
{
    public class Masters : Jedi.Jedi, IMasters
    {
        protected int damadgeKnolidgh;
        protected int thePower;
        protected int point;

        public Masters(int points, Asistents asistent) : base(points, asistent)
        {
        }

        public Masters():base()
        {
        }

        public override void Points()
        {
            throw new System.NotImplementedException();
        }
    }
}