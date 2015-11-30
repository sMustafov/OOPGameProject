﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jedis;
using Jedis.Inerface;

namespace Game.Jedis
{
    class JediFactory
    {
        public static IJedi CreatJedi(JediType type)
        {
            switch (type)
            {
                case JediType.JoNakov:
                    return new JoNakov();
                case JediType.AchoUanKenobi:
                    return new AchoUanKenobi();
                case JediType.BodanakiSkyeWalker:
                    return new BadanakiSkeyWalker();
                case JediType.NicSolo:
                    return new NicSolo();
                default:
                    throw new ArgumentException();
            } 
        }
    }
}