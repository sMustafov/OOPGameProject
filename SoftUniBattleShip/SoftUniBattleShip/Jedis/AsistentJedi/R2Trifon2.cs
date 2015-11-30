using System;
using Game.Inerface;
using Jedis;

namespace Game
{
    public class R2Trifon2 : Asistents, IR2Trifon2
    {
        public R2Trifon2(int poits) : base(poits)
        {
        }

        public R2Trifon2() : base()
        {
            this.AsistentJediType = AsistentJediType.R2Trifon2;
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