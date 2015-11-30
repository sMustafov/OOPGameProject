using System;
using Jedis;

namespace Game.Paduins
{
    public class AsistentPaduinFactory
    {
        public static IAsistentsPaduin CreateAsistentPaduin(AsistentPaduinType type)
        {
            switch (type)
            {
                case AsistentPaduinType.FugelmanToWookie:
                    return new FugelmanToWookie();
                case AsistentPaduinType.SipiTriBiriO:
                    return new SipiTriBiriO();
                default:
                   throw new ArgumentException();
            }
        }
    }
}