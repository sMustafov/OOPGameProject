using WindowsFormsApplication1.Paduins;

namespace WindowsFormsApplication1.Interface.IPadaun.IPaduinStudents
{
    public interface IPaduin
    {
        string NickName { get; set; }

        int PointKnowledge { get; set; }

        int PaduinPower { get; set; }

        int BeerPerSecond { set; get; }

        PaduinType PaduinType { get; set; }

        void KnowledgeCalculator();
    }
}