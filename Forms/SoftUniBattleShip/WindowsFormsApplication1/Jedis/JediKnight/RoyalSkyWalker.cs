﻿using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi.IJediKnight;
using WindowsFormsApplication1.Jedis.AsistentJedi;

namespace WindowsFormsApplication1.Jedis.JediKnight
{
    public class RoyalSkyWalker : JediKnight, IRoyalSkyWalker
    {
        private string characterImage = @"..\..\Resources\Royal.png";
        
        public RoyalSkyWalker() : base()
        {
            this.JediType = JediType.RoyalSkyWalker;
            this.knowledgeDamage = 15;
            this.thePower = 70;
            this.points = 10;
        }

        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
        }

        public override int KnowledgeDamage
        {
            get { return this.knowledgeDamage; }
            set { this.knowledgeDamage = value; }
        }

        public override int ThePolerOfDrinks
        {
            get { return this.thePower; }
            set { this.thePower = value; }
        }

        public override int PointsDamage
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public override void Points()
        {
            if (this.PointsDamage > this.ThePolerOfDrinks)
            {
                Console.WriteLine("RoyalSkyWalker is drunk!!!");
            }
        }
    }
}