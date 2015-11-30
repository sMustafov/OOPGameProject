using Jedis.Inerface;

namespace Jedis.Jedi
{
    public abstract class Jedi : IJedi
    {
        public Jedi(int points, Asistents asist)
        {
            PointsDamadje = points;
            Asistent = asist;
        }

        public Jedi()
        {
        }

        public virtual int PointsDamadje { get; set; }

        public virtual int DemidjeKnolidge { get; set; }

        public virtual int ThePolerOfDrinks { get; set; }

        public JediType JediType { get; set; }

        public virtual Asistents Asistent { get; set; }

        public abstract void Points();
    }
}