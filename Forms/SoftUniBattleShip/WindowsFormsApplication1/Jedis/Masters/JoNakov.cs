using System;
using System.Drawing;
using Jedis;

namespace Game
{
    public class JoNakov : Masters, IJoNakov
    {
        private string characterImage = @"C:\Users\pc1\Desktop\OOPGameProject\OOPGameProject\Forms\SoftUniBattleShip\WindowsFormsApplication1\Resources\nakov.jpg";

        public JoNakov() : base()
        {
            this.JediType = JediType.JoNakov;
        }

        public JoNakov(int points, Assistant assistant, string characterImage) : base(points, assistant)
        {
            this.CharacterImage = characterImage;
        }

        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
        }

        public override int KnowledgeDamage
        {
            get { return this.knowledgeDamage; }
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