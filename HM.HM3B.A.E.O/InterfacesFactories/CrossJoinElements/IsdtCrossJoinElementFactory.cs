namespace HM.HM3B.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IsdtCrossJoinElementFactory
    {
        IsdtCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IdIndexElement dIndexElement,
            ItIndexElement tIndexElement);
    }
}