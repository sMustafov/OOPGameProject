using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IPadaun.IAssistantPaduin;
using WindowsFormsApplication1.Paduins.AssistantPaduin;

namespace WindowsFormsApplication1.Paduins
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