namespace SoftUniBattleShip.Jedis.JediKnight
{
    using System;
    
    using Interface;
    using Interface.IJedi.IJediKnight;
    using AsistentJedi;
   
    public class NaskoSolo : JediKnight, INaskoSolo
    {
        public NaskoSolo(int points, Assistant assistant) : base(points, assistant)
        {
        }

        public NaskoSolo() : base()
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