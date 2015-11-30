using Jedis;

namespace Game
{
    public abstract class Paduin : IPaduin
    {
        protected int paduinPower;
        protected int beerPerSecound;
        protected int pointKnowledge;
        protected AsistensPaduin asistensPaduin;

        public Paduin(int pointKnowledge, AsistensPaduin asistensPaduin)
        {
            PointKnowledge = pointKnowledge;
            AsistensPaduin = asistensPaduin;
        }

        public Paduin()
        {
        }

        public int PointKnowledge { get; set; }

        public int PaduinPower { get; set; }

        public int BeerPerSecund { get; set; }

        public PaduinType PaduinType { get; set; }

        public AsistensPaduin AsistensPaduin { get; set; }

        public abstract void KnolidgeCalkulater();
    }
}