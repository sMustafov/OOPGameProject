using System;
using Jedis;

namespace Game
{
    public class AchoUanKenobi : JediKnight, IAchoUanKenobi
    {
        private string characterImage = @"C:\Users\pc1\Desktop\OOPGameProject\OOPGameProject\Forms\SoftUniBattleShip\WindowsFormsApplication1\Resources\acho.jpg";
        public AchoUanKenobi(int points, Assistant assistant) : base(points, assistant)
        {
        }

        public AchoUanKenobi() : base()
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
