namespace SoftUniBattleShip.Jedis
{
    using System; 

    using Inerface;
    using Interface;
    using JediKnight;
    using Masters;

    class JediFactory
    {
        public static IJedi CreateJedi(JediType type)
        {
            switch (type)
            {
                case JediType.JoNakov:
                    return new JoNakov();
                case JediType.AchoUanKenobi:
                    return new AchoUanKenobi();
                case JediType.RoyalSkyWalker:
                    return new RoyalSkyWalker();
                case JediType.NaskoSolo:
                    return new NaskoSolo();
                default:
                    throw new ArgumentException();
            } 
        }
    }
}
