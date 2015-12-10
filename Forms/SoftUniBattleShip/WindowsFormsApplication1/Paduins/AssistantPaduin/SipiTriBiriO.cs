using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IPadaun.IAssistantPaduin;

namespace WindowsFormsApplication1.Paduins.AssistantPaduin
{
    public class SipiTriBiriO : AssistantPaduin, ISipiTriBitiO
    {
        public SipiTriBiriO(int points) : base(points)
        {
        }

        public SipiTriBiriO()
        {
            this.AssistantPaduinType = AssistantPaduinType.SipiTriBiriO;
        }

        public  int AssistantLives
        {
            get { return this.assistantLives; }
            set { this.assistantLives = 40; }
        }

        public new int AssistantAttack
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