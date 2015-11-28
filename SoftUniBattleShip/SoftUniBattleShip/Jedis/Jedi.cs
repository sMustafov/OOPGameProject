using Jedis.Inerface;

namespace Jedis.Jedi
{
    public abstract class Jedi : IJedi
    {
        

        public virtual int Points { get; set; }

        public virtual int DemidjeKnolidge { get; set; }

        public virtual int ThePolerOfDinks { get; }

        public abstract void DrinkPromilCalculater();
    }
}