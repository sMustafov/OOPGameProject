using Jedis;

namespace Game
{
    public class SashoFett : Paduin, ISashoFett
    {
        public SashoFett(int damage, int beerPerSesund) : base(damage, beerPerSesund)
        {
        }

        public override void KnolidgeCalkulater()
        {
            throw new System.NotImplementedException();
        }
    }
}