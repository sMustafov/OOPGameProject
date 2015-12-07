using System.Drawing;
using Jedis.Inerface;

namespace Jedis.Jedi
{
    public abstract class Jedi : IJedi
    {
        private Image characterImage;

        protected Jedi(int points, Assistant assistant)
        {
            this.PointsDamage = points;
            this.Assistant = assistant;
        }

        protected Jedi()
        {
        }

        public string NickName { get; set; }

        public virtual int PointsDamage { get; set; }

        public virtual int KnowledgeDamage { get; set; }

        public virtual int ThePolerOfDrinks { get; set; }

        public JediType JediType { get; set; }

        public virtual Assistant Assistant { get; set; }

        public abstract string CharacterImage { get; set; }

        public abstract void Points();
    }
}