using SoftUniBattleShip.Interface;
using SoftUniBattleShip.Interface.IPadaun.IPaduinStudents;
using SoftUniBattleShip.Paduins.Paduin;

namespace SoftUniBattleShip.Paduins
{
    using System;


    public class PadoinFactor
    {
        public static IPaduin CreatePaduin(PaduinType type)
        {
            switch (type)
            {
                case PaduinType.Karnotman:
                    return new Karnobatman();
                case PaduinType.CountSevgin:
                    return new CountSevgin();
                case PaduinType.SashoFett:
                    return new SashoFett();
                    case PaduinType.WightJan:
                    return new WightJan();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
