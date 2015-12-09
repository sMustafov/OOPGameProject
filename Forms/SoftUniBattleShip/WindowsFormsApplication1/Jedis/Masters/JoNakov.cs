using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi.IMasters;
using WindowsFormsApplication1.Jedis.AsistentJedi;

namespace WindowsFormsApplication1.Jedis.Masters
{
    public class JoNakov : Masters, IJoNakov
    {
        private string characterImage = @"..\..\Resources\nakov.jpg";

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