namespace HM.HM3B.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IslCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IlIndexElement lIndexElement { get; }
    }
}