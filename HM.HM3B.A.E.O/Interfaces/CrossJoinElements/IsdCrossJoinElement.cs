namespace HM.HM3B.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IsdCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IdIndexElement dIndexElement { get; }
    }
}