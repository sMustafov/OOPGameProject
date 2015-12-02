using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jedis;

namespace Game.Paduins
{
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
