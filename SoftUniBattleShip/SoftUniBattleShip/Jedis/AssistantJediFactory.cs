namespace SoftUniBattleShip.Jedis
{
    using System;
    using Interface;

    using Interface.IJedi.IAssistants;
    using AsistentJedi;
    
    public class AssistantJediFactory
    {
        public static IAssistants CreateJediАssistant(AssistantJediType type)
        {
            switch (type)
            {
                case AssistantJediType.ChubiEdo:
                    return new ChubiEdo();
                case AssistantJediType.R2Trifon2:
                    return new R2Trifon2();
                default:
                    throw new ArgumentException();
            }
        }
    }
}