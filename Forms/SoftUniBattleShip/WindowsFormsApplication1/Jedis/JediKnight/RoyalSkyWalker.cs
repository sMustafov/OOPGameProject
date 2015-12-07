using System;
using Game.Inerface;
using Jedis;

namespace Game
{
    public class RoyalSkyWalker : JediKnight, IRoyalSkyWalker
    {
        private string characterImage = @"C:\Users\pc1\Desktop\OOPGameProject\OOPGameProject\Forms\SoftUniBattleShip\WindowsFormsApplication1\Resources\royal.jpg";
        public RoyalSkyWalker(int points, Assistant assistant) : base(points, assistant)
        {
        }

        public RoyalSkyWalker() : base()
        {
            this.JediType = JediType.RoyalSkyWalker;
        }

        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
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
                Console.WriteLine("RoyalSkyWalker is drunk!!!");
            }
        }
    }
}