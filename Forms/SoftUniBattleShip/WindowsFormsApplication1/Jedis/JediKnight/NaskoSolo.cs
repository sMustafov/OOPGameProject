﻿using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi.IJediKnight;
using WindowsFormsApplication1.Jedis.AsistentJedi;

namespace WindowsFormsApplication1.Jedis.JediKnight
{
    public class NaskoSolo : JediKnight, INaskoSolo
    {
        private string characterImage = @"..\..\Resources\Nasko.png";

        public NaskoSolo(int points, Assistant assistant) : base(points, assistant)
        {
        }

        public NaskoSolo() : base()
        {
            this.JediType = JediType.NaskoSolo;
        }

        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
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
                Console.WriteLine("NaskoSolo is drunk!!!");
            }
        }
    }
}