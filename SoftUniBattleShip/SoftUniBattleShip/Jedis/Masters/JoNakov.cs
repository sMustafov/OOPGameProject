using System;
using Jedis;

namespace Game
{
    public class JoNakov : Masters, IJoNakov
    {
        
        public JoNakov() : base() 
        {
            this.JediType = JediType.JoNakov;
        }

        public JoNakov(int points, Asistents asistent) : base(points, asistent)
        {

        }


        public override int DemidjeKnolidge
        {
            get {return this.damadgeKnolidgh; }
            set { this.damadgeKnolidgh = 30; }
        }

        public override int ThePolerOfDrinks
        {
            get { return this.thePower; }
            set { this.thePower = 100; }
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
                Console.WriteLine("JoNakov is drunk!!!");
            }
        }
    }
}