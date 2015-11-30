using System;
using Jedis;

namespace Game
{
    public class CountSevgin : Paduin,ICountSevgin
    {
        public CountSevgin(int pointKnowledge, AsistensPaduin asistensPaduin) 
            : base(pointKnowledge, asistensPaduin)
        {

        }

        public CountSevgin() : base()
        {
            this.PaduinType = PaduinType.CountSevgin;
        }

        public int PointKnowledge1
        {
            get { return this.pointKnowledge; }
            set { this.pointKnowledge += value; }
        }

        public int PaduinPower
        {
            get { return this.paduinPower; }
            set { this.paduinPower = 50; }
        }

        public int BeerPerSecound
        {
            get { return this.beerPerSecound; }
            set { this.beerPerSecound = 3; }
        }

        public override void KnolidgeCalkulater()
        {
            if (PaduinPower < PointKnowledge)
            {
                Console.WriteLine("Paduin have very knowledge");
            }
        }
    }
}