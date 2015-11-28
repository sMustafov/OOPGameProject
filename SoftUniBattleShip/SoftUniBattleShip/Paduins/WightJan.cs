using Jedis;

namespace Game
{
    public class WightJan : Paduin,IWightJan
    {
        public WightJan(int damage, int beerPerSesund) : base(damage, beerPerSesund)
        {
        }

        public override void KnolidgeCalkulater()
        {
            throw new System.NotImplementedException();
        }
    }
}