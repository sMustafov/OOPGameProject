using System;
using Game.Inerface;
using Jedis;

namespace Game
{
    public class FugelmanToWookie : AsistensPaduin, IFugelmanToWookie
    {
        public FugelmanToWookie(int poits) : base(poits)
        {
        }

        public FugelmanToWookie() : base()
        {
            this.AsistentPaduinType = AsistentPaduinType.FugelmanToWookie;
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