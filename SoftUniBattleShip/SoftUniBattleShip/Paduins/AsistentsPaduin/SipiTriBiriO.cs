using System;
using Game.Inerface;
using Jedis;

namespace Game
{
    public class SipiTriBiriO : AsistensPaduin, ISipiTriBitiO
    {
        public SipiTriBiriO(int poits) : base(poits)
        {
        }

        public SipiTriBiriO() : base()
        {
            this.AsistentPaduinType = AsistentPaduinType.SipiTriBiriO;
        }

        public override int AsistentsLive
        {
            get { return this.asistentsLive; }
            set { this.asistentsLive = 40; }
        }

        public int AsistentsAttack
        {
            get { return this.asistentsAttack; }
            set { this.asistentsAttack = 5; }
        }

        public override int AsistentPoint
        {
            get { return this.asistPoint; }
            set
            { this.asistPoint += value; }
        }

        public override void Point()
        {
            if (AsistentPoint > AsistentsLive)
            {
                Console.WriteLine("CubaEdo is drunk!!!");
            }
        }
    }
}