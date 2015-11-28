using Jedis;

namespace Game
{
    public abstract class Paduin : IStudent
    {
        protected const int MAX_KNLIDGE_GET = 100;

        public Paduin(int damage, int beerPerSesund)
        {
            Damage = damage;
            BeerPerSecund = beerPerSesund;
        }

        public int Damage { get; set; }

        public int BeerPerSecund { get; set; }
        public abstract void KnolidgeCalkulater();

    }
}