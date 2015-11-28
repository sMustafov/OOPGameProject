using Game.Inerface;
using Jedis;

namespace Game
{
    public class R2Trifon2 : Asistents, IR2Trifon2
    {
        public R2Trifon2(int sistAtak, AssistType assistType) : base(sistAtak, assistType)
        {
        }
    }
}