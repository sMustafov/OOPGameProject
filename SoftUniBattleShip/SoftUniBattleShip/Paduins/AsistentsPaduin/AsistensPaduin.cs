using Game.Inerface;
using Jedis;

namespace Game
{
    public abstract class AsistensPaduin : IAsistentsPaduin
    {
        protected int asistentsAttack;
        protected int asistentsLive;
        protected int asistPoint;

        public AsistensPaduin(int sistAtak)
        {
            AssistentistAttack = sistAtak;
        }

        public AsistensPaduin()
        {
        }

        public virtual int AsistentPoint { get; set; }

        public virtual int AssistentistAttack { get; set; }

        public virtual int AsistentsLive { get; set; }

        public AsistentPaduinType AsistentPaduinType { get; set; }

        public abstract void Point();
    }
}