using Game.Inerface;
using Game.Jedis;
using Game.Paduins;

namespace Jedis.Engine
{
    public class EnginePatka // Test Engine
    {
        public static void EnterBatel(string input)
        {
            string[] inputCommand = input.Split(' ');
            switch (inputCommand[0])
            {
                case "CreateJediPlayer":
                    CreateJediPlayer(inputCommand);
                    break;
                case "CreatePaduinPlayer":
                    break;
            }
        }

        private static void CreateJediPlayer(string[] inputCommands)
        {
            switch (inputCommands[1])
            {
                case "JoNakov":
                    var joNakov = (IJoNakov) JediFactory.CreateJedi(JediType.JoNakov);
                    break;
                case "AchoUanKenobi":
                    var achoUanKenobi = (IAchoUanKenobi) JediFactory.CreateJedi(JediType.AchoUanKenobi);
                    break;
                case "RoyalSkeyWalker":
                    var royalSkyeWalker = (IRoyalSkyWalker) JediFactory.CreateJedi(JediType.RoyalSkyWalker);
                    break;
                case "NaskoSolo":
                    var naskoSolo = (INaskoSolo) JediFactory.CreateJedi(JediType.NaskoSolo);
                    break;
            }
        }

        private static void CreatePaduinPlayer(string[] inputCommands)
        {
            switch (inputCommands[1])
            {
                case "CountSevgin":
                    var countSevgin = (ICountSevgin) PadoinFactor.CreatePaduin(PaduinType.CountSevgin);
                    break;
                case "Karnobatman":
                    var karnobatman =
                        (IKarnobatmanFromKranobasterdam) PadoinFactor.CreatePaduin(PaduinType.Karnotman);
                    break;
                case "SashoFett":
                    var sashoFett = (ISashoFett) PadoinFactor.CreatePaduin(PaduinType.SashoFett);
                    break;
                case "WightJan":
                    var wightJan = (IWightJan) PadoinFactor.CreatePaduin(PaduinType.WightJan);
                    break;
            }
        }

        private static void CreateAssistantJedi(string[] inputCommand)
        {
            switch (inputCommand[1])
            {
                case "ChubiEdo":
                    var chubiEdo = (IAssistants) AssistantJediFactory.CreateJediАssistant(AssistantJediType.ChubiEdo);
                    break;
                case "R2Trifon2":
                    var r2Trifon2 = (IAssistants) AssistantJediFactory.CreateJediАssistant(AssistantJediType.R2Trifon2);
                    break;
            }
        }

        private static void CreateAssistantPaduin(string[] inputCommand)
        {
            switch (inputCommand[1])
            {
                case "FugelmanToWookie":
                    var fugelmabToWookie =
                        (IAssistantPaduin)
                            AssistantPaduinFactory.CreateAssistantPaduin(AssistantPaduinType.FugelmanToWookie);
                    break;
                case "SipiTriBiriO":
                    var sipiTriBiriO = (IAssistantPaduin) AssistantPaduinFactory.CreateAssistantPaduin(AssistantPaduinType.SipiTriBiriO);
                    break;
            }
        }
    }
}