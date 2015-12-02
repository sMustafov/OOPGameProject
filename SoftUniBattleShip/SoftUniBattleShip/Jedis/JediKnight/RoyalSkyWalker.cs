﻿using System;
using Game.Inerface;
using Jedis;

namespace Game
{
    public class BadanakiSkeyWalker : JediKnight, IRoyalSkyWalker
    {
        public BadanakiSkeyWalker(int points, Assistant assistant) : base(points, assistant)
        {
        }

        public BadanakiSkeyWalker() : base()
        {
            this.JediType = JediType.RoyalSkyWalker;
        }

        public override int KnowledgeDamage
        {
            get { return this.knowledgeDamage; }
            set { this.knowledgeDamage = 15; }
        }

        public override int ThePolerOfDrinks
        {
            get { return this.thePower; }
            set { this.thePower = 70; }
        }

        public override int PointsDamage
        {
            get { return points; }
            set { this.points += value; }
        }

        public override void Points()
        {
            if (PointsDamage > ThePolerOfDrinks)
            {
                Console.WriteLine("RoyalSkyWalker is drunk!!!");
            }
        }
    }
}