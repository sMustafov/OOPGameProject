using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IPadaun.IAssistantPaduin;

namespace WindowsFormsApplication1.Paduins.AssistantPaduin
{
    public class FugelmanToWookie : AssistantPaduin, IFugelmanToWookie
    {
        public FugelmanToWookie(int points) : base(points)
        {
        }

        public FugelmanToWookie() : base()
        {
            this.AssistantPaduinType = AssistantPaduinType.FugelmanToWookie;
        }

        public int AssistantLives
        {
            get { return this.assistantLives; }
            set { this.assistantLives = 40; }
        }

        public int AssistantAttack
        {
            get { return this.assistantAttack; }
            set { this.assistantAttack = 5; }
        }

        public int AssistantPoints
        {
            get { return this.assistantPoints; }
            set
            { this.assistantPoints += value; }
        }

        public override void Point()
        {
            if (AssistantPoints > AssistantLives)
            {
                Console.WriteLine("CubaEdo is drunk!!!");
            }
        }
    }
}