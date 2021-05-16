namespace HM.HM3B.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IstCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        ItIndexElement tIndexElement { get; }
    }
}