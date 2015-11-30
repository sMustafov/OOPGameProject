using System;
using Jedis;

namespace Game
{
    public class NicSolo : JediKnight, INicSolo
    {
        public NicSolo(int points, Asistents asistent) : base(points, asistent)
        {
        }

        public NicSolo() : base()
        {
            this.JediType = JediType.NicSolo;
        }

        public override int DemidjeKnolidge
        {
            get { return this.damadgeKnolidgh; }
            set { this.damadgeKnolidgh = 15; }
        }

        public override int ThePolerOfDrinks
        {
            get { return this.thePower; }
            set { this.thePower = 70; }
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