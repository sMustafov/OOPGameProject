using Jedis;

namespace Game
{
    public class NicSolo : JediKnight, INicSolo
    {
        public NicSolo(int points, int demidg, int thePler) : base(points, demidg, thePler)
        {
        }
    }
}