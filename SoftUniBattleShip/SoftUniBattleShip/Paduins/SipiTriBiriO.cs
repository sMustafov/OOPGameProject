using Game.Inerface;
using Jedis;

namespace Game
{
    public class SipiTriBiriO : AsistensPaduin, ISipiTriBitiO
    {
        public SipiTriBiriO(int sistAtak, AssistType assistType) : base(sistAtak, assistType)
        {
        }
    }
}