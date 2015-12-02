namespace SoftUniBattleShip.Jedis.Masters
{
    using System;

    using Interface.IJedi.IMasters;
    using AsistentJedi;
    using Interface;

    public class JoNakov : Masters, IJoNakov
    {
        
        public JoNakov() : base() 
        {
            this.JediType = JediType.JoNakov;
        }

        public JoNakov(int points, Assistant assistant) : base(points, assistant)
        {

        }


        public override int KnowledgeDamage
        {
            get {return this.knowledgeDamage; }
            set { this.knowledgeDamage = 30; }
        }

        public override int ThePolerOfDrinks
        {
            get { return this.thePower; }
            set { this.thePower = 100; }
        }

        public override int PointsDamage
        {
            get { return point; }
            set { this.point += value; }
        }

        public override void Points()
        {
            if (PointsDamage > ThePolerOfDrinks)
            {
                Console.WriteLine("JoNakov is drunk!!!");
            }
        }
    }
}