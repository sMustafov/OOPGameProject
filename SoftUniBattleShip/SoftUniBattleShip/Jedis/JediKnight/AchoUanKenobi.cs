namespace SoftUniBattleShip.Jedis.JediKnight
{
    using System;
  
    using Interface;
    using Interface.IJedi.IJediKnight;
    using AsistentJedi;

    public class AchoUanKenobi : JediKnight, IAchoUanKenobi
    {

        public AchoUanKenobi(int points, Assistant assistant) : base(points, assistant)
        {
        }

        public AchoUanKenobi() : base()
        {
            this.JediType = JediType.AchoUanKenobi;
        }

        public override int KnowledgeDamage
        {
            get { return this.knowledgeDamage; }
            set { this.knowledgeDamage = 20; }
        }

        public override int ThePolerOfDrinks
        {
            get { return this.thePower; }
            set { this.thePower = 80; }
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
                Console.WriteLine("AchoUanKenobi is drunk!!!");
            }
        }
    }
}
