using System;
using Game.Inerface;
using Jedis;

namespace Game
{
    public class BadanakiSkeyWalker : JediKnight, IBodanakinСkywalker
    {
        public BadanakiSkeyWalker(int points, Asistents asistent) : base(points, asistent)
        {
        }

        public BadanakiSkeyWalker() : base()
        {
            this.JediType = JediType.BodanakiSkyeWalker;
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