using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi.IJediKnight;
using WindowsFormsApplication1.Jedis.AsistentJedi;

namespace WindowsFormsApplication1.Jedis.JediKnight
{
    public class AchoUanKenobi : JediKnight, IAchoUanKenobi
    {
        private string characterImage = @"..\..\Resources\Acho.png";
        public AchoUanKenobi(int points, Assistant assistant) : base(points, assistant)
        {
        }

        public AchoUanKenobi()
        {
            this.JediType = JediType.AchoUanKenobi;
        }
        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
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
