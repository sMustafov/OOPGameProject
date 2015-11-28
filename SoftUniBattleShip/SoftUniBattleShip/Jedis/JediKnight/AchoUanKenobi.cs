using Jedis;

namespace Game
{
    public class AchoUanKenobi : JediKnight, IAcuUanKenobi
    {
        public AchoUanKenobi(int points, int demidg, int thePler) : base(points, demidg, thePler)
        {
        }
    }
}