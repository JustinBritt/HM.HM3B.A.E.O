namespace HM.HM3B.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface ItΛCrossJoinElement
    {
        ItIndexElement tIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }
    }
}