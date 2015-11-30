using System;
using Jedis;

namespace Game.Jedis
{
    public class AssistantJediFactory
    {
        public static IAssistants CreateJediАsistant(AssistantJediType type)
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