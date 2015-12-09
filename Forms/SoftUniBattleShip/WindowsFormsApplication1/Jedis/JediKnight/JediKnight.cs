using WindowsFormsApplication1.Interface.IJedi.IJediKnight;
using WindowsFormsApplication1.Jedis.AsistentJedi;

namespace WindowsFormsApplication1.Jedis.JediKnight
{
    public class JediKnight : Jedi, IJediKnight
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