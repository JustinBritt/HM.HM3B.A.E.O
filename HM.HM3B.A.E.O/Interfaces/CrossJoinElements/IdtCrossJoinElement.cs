namespace HM.HM3B.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IdtCrossJoinElement
    {
        IdIndexElement dIndexElement { get; }

        ItIndexElement tIndexElement { get; }
    }
}