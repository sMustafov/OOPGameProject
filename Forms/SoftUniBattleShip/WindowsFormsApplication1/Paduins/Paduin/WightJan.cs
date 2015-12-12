﻿using System;
using WindowsFormsApplication1.Interface.IPadaun.IPaduinStudents;

namespace WindowsFormsApplication1.Paduins.Paduin
{
    using AssistantPaduin;

    public class WightJan : Paduin, IWightJan
    {
        private string characterImage = @"..\..\Resources\Jan.png";

        public override int BeerPerSecond
        {
            get { return this.beerPerSecond; }
            set { this.beerPerSecond = 3; }
        }

        public override PaduinType PaduinType { get; set; }

        public override AssistantPaduin AssistantPaduin { get; set; }

        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
        }

        public override int PointKnowledge
        {
            get { return this.pointKnowledge; }
            set { this.pointKnowledge += value; }
        }

        public override int PaduinPower
        {
            get { return this.paduinPower; }
            set { this.paduinPower = 50; }
        }

        public override void KnowledgeCalculator()
        {
            if (this.PaduinPower < this.PointKnowledge)
            {
                Console.WriteLine("Paduin have knowledge");
            }
        }
    }
}