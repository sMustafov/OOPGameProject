namespace SoftUniBattleShip.Paduins
{
    using System;
    using Interface;
    using Interface.IPadaun.IAssistantPaduin;
    using AssistantPaduin;

    public class AssistantPaduinFactory
    {
        public static IAssistantPaduin CreateAssistantPaduin(AssistantPaduinType type)
        {
            switch (type)
            {
                case AssistantPaduinType.FugelmanToWookie:
                    return new FugelmanToWookie();
                case AssistantPaduinType.SipiTriBiriO:
                    return new SipiTriBiriO();
                default:
                   throw new ArgumentException();
            }
        }
    }
}