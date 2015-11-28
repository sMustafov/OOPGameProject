using Game.Inerface;
using Jedis;

namespace Game
{
    public class FugelmanToWookie : AsistensPaduin, IFugelmanToWookie
    {
        public FugelmanToWookie(int sistAtak, AssistType assistType) : base(sistAtak, assistType)
        {
        }
    }
}