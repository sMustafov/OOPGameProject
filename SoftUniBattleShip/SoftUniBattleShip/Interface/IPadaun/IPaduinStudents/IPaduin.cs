namespace Jedis
{
    public interface IPaduin
    {
        int PointKnowledge { get; set; }

        int PaduinPower { get; set; }

        int BeerPerSecund { set; get; }

        PaduinType PaduinType { get; set; }

        void KnolidgeCalkulater();
    }
}