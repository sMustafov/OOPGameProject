using System;
using Jedis;

namespace Game.Paduins
{
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