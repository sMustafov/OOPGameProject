using Jedis;

namespace Game
{
    public class JoNakov : Masters, IJoNakov
    {
         
        public override int DemidjeKnolidge
        {
            get {return this.damadgeKnolidgh; }
            private set { this.damadgeKnolidgh = 30; }
        }

        public int ThePower
        {
            get { return this.thePower; }
            set { this.thePower = 100; }
        }
    }
}