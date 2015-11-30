using System;
using Jedis;

namespace Game
{
    public class NicSolo : JediKnight, INaskoSolo
    {
        public NicSolo(int points, Assistant assistant) : base(points, assistant)
        {
        }

        public NicSolo() : base()
        {
            this.JediType = JediType.NaskoSolo;
        }

        public override int KnowledgeDamage
        {
            get { return this.knowledgeDamage; }
            set { this.knowledgeDamage = 15; }
        }

        public override int ThePolerOfDrinks
        {
            get { return this.thePower; }
            set { this.thePower = 70; }
        }

        public override int PointsDamage
        {
            get { return points; }
            set { this.points += value; }
        }

        public override void Points()
        {
            if (PointsDamage > ThePolerOfDrinks)
            {
                Console.WriteLine("NaskoSolo is drunk!!!");
            }
        }
    }
}