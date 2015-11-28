using Game.Inerface;

namespace Jedis
{
    public class Asistents : IAsistents
    {
        public Asistents(int sistAtak, AssistType assistType)
        {
            AssistType = assistType;
            AssistentistAttack = sistAtak;
        }

        public int AssistentistAttack { get; set; }

        public AssistType AssistType { get; set; }
    }
}