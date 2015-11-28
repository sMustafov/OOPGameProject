using Game.Inerface;
using Jedis;

namespace Game
{
    public class ChubiEdo : Asistents, IChubiEdo
    {
        public ChubiEdo(int sistAtak, AssistType assistType) : base(sistAtak, assistType)
        {
        }
    }
}