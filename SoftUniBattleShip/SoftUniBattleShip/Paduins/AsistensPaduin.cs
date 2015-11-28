using Game.Inerface;
using Jedis;

namespace Game
{
    public class AsistensPaduin : IAsistents
    {
        public AsistensPaduin(int sistAtak, AssistType assistType)
        {
            AssistType = assistType;
            AssistentistAttack = sistAtak;
        }

        public int AssistentistAttack { get; set; }
        public AssistType AssistType { get; set; }
    }
}