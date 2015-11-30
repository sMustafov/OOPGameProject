﻿using Game.Inerface;

namespace Jedis
{
    public class Asistents : IAsistents
    {
        protected int asistentsAttack;
        protected int asistentsLive;
        protected int asistPoint;

        protected Asistents(int poits)
        {
            AsistentPoint = poits;
        }

        protected Asistents()
        {
        }

        public virtual int AsistentPoint { get; set; }

        public virtual int AssistentistAttack { get; set; }

        public virtual int AsistentsLive { get; set; }

        public AsistentJediType AsistentJediType { get; set; }

        public virtual void Point()
        {
            throw new System.NotImplementedException();
        }
    }
}