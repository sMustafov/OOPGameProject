

using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace Jedis
{
    public class JediKnight : Jedi.Jedi, IJediKnight
    {
     
        protected int knowledgeDamage;
        protected int thePower;
        protected int points;

        public JediKnight(int points, Assistant assistant) : base(points, assistant)
        {
            
        }

        public JediKnight():base()
        {
        }

        public override string CharacterImage { get; set; }

        public override void Points()
        {
            throw new System.NotImplementedException();
        }
    }
}