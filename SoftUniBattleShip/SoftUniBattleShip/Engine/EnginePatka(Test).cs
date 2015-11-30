using System.Diagnostics;
using Game.Inerface;
using Game.Jedis;
using Game.Paduins;

namespace Jedis.Engine
{
    public class EnginePatka // Test Engine
    {
        public static void EnterBatel(string input)
        {
            string[] inputComand = input.Split(' ');
            switch (inputComand[0])
            {
                case "CreatJediPlayer":
                    CreaJeditPlayr(inputComand);
                    break;
                case "CreatPaduinlayr":
                    break;
            }
        }

        private static void CreaJeditPlayr(string[] inputComands)
        {
            switch (inputComands[1])
            {
                case "JoNakov":
                    var joNakov = (IJoNakov) JediFactory.CreatJedi(JediType.JoNakov);
                    break;
                case "AchoUanKenobi":
                    var achoUanKenobi = (IAcuUanKenobi) JediFactory.CreatJedi(JediType.AchoUanKenobi);
                    break;
                case "BadanakiSkeyWalker":
                    var badanakiSkyeWalker = (IBodanakinСkywalker) JediFactory.CreatJedi(JediType.BodanakiSkyeWalker);
                    break;
                case "NicSolo":
                    var nicSolo = (INicSolo) JediFactory.CreatJedi(JediType.NicSolo);
                    break;
            }
        }

        private static void CreatPaduinPlayr(string[] inputComands)
        {
            switch (inputComands[1])
            {
                case "CountSevgin":
                    var countSevgin = (ICountSevgin) PadoinFactor.CreatPaduin(PaduinType.CountSevgin);
                    break;
                case "Karnobatman":
                    var karnobatman =
                        (IKarnobatmanFromKranobasterdam) PadoinFactor.CreatPaduin(PaduinType.Karnotman);
                    break;
                case "SashoFett":
                    var sashoFett = (ISashoFett) PadoinFactor.CreatPaduin(PaduinType.SashoFett);
                    break;
                case "WightJan":
                    var wightJan = (IWightJan) PadoinFactor.CreatPaduin(PaduinType.WightJan);
                    break;
            }
        }

        private static void CreatAsistentJedi(string[] inputComand)
        {
            switch (inputComand[1])
            {
                case "ChubiEdo":
                    var chubiEdo = (IAsistents) AsistentJediFaktory.CreatJediАсistents(AsistentJediType.ChubiEdo);
                    break;
                case "R2Trifon2":
                    var r2Trifon2 = (IAsistents) AsistentJediFaktory.CreatJediАсistents(AsistentJediType.R2Trifon2);
                    break;
            }
        }

        private static void CreatAsistentPaduin(string[] inputComand)
        {
            switch (inputComand[1])
            {
                case "FugelmanToWookie":
                    var fugelmabToWookie =
                        (IAsistentsPaduin)
                            AsistentPaduinFactory.CreateAsistentPaduin(AsistentPaduinType.FugelmanToWookie);
                    break;
                case "SipiTriBitiO":
                    var sipiTriBirirO = (IAsistentsPaduin) AsistentPaduinFactory.CreateAsistentPaduin(AsistentPaduinType.SipiTriBiriO);
                    break;
            }
        }
    }
}