using Jedis;

namespace Game
{
    public class KarnobatmanFromKranobasterdam : Paduin, IKarnobatmanFromKranobasterdam
    {
        public KarnobatmanFromKranobasterdam(int damage, int beerPerSesund) : base(damage, beerPerSesund)
        {
        }

        public override void KnolidgeCalkulater()
        {
            throw new System.NotImplementedException();
        }
    }
}