﻿using System;
using System.Reflection;
using Game.Inerface;
using Jedis;

namespace Game
{
    public class ChubiEdo : Asistents, IChubiEdo
    {
        public ChubiEdo(int poits) : base(poits)
        {
        }

        public ChubiEdo() : base()
        {
            this.AsistentJediType = AsistentJediType.ChubiEdo;
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