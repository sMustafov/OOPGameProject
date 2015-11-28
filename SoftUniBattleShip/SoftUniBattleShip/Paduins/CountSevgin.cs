using Jedis;

namespace Game
{
    public class CountSevgin : Paduin,ICountSevgin
    {
        public CountSevgin(int damage, int beerPerSesund) : base(damage, beerPerSesund)
        {
        }

        public override void KnolidgeCalkulater()
        {
            throw new System.NotImplementedException();
        }
    }
}