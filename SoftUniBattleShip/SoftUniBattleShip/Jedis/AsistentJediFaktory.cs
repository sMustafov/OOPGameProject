using System;
using Jedis;

namespace Game.Jedis
{
    public class AsistentJediFaktory
    {
        public static IAsistents CreatJediАсistents(AsistentJediType type)
        {
            switch (type)
            {
                case AsistentJediType.ChubiEdo:
                    return new ChubiEdo();
                case AsistentJediType.R2Trifon2:
                    return new R2Trifon2();
                default:
                    throw new ArgumentException();
            }
        }
    }
}