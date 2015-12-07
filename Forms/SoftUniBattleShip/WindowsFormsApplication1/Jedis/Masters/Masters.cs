using System.Drawing;
using System.Windows.Forms;

namespace Jedis
{
    public abstract class Masters : Jedi.Jedi, IMasters
    {
        protected int knowledgeDamage;
        protected int thePower;
        protected int point;

        public Masters(int points, Assistant assistant) : base(points, assistant)
        {
        }

        public Masters():base()
        {
        }

        public override void Points()
        {
            throw new System.NotImplementedException();
        }
    }
}