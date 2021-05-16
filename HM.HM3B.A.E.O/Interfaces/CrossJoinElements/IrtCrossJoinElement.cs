namespace HM.HM3B.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IrtCrossJoinElement
    {
        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }
    }
}