using System;
using Jedis;

namespace Game
{
    public class AchoUanKenobi : JediKnight, IAcuUanKenobi
    {

        public AchoUanKenobi(int points, Asistents asistent) : base(points, asistent)
        {
        }

        public AchoUanKenobi() : base()
        {
            this.JediType = JediType.AchoUanKenobi;
        }

        public override int DemidjeKnolidge
        {
            get { return this.damadgeKnolidgh; }
            set { this.damadgeKnolidgh = 20; }
        }

        public override int ThePolerOfDrinks
        {
            get { return this.thePower; }
            set { this.thePower = 80; }
        }

        public override int PointsDamadje
        {
            get { return point; }
            set { this.point += value; }
        }

        public override void Points()
        {
            if (PointsDamadje > ThePolerOfDrinks)
            {
                Console.WriteLine("AchoUanKenobi is drunk!!!");
            }
        }
    }
}
