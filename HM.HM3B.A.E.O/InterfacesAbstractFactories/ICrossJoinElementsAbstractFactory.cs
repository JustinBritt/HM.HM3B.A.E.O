namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoinElements;

    public interface ICrossJoinElementsAbstractFactory
    {
        IdtCrossJoinElementFactory CreatedtCrossJoinElementFactory();

        ImrCrossJoinElementFactory CreatemrCrossJoinElementFactory();

        IrtCrossJoinElementFactory CreatertCrossJoinElementFactory();

        IsdCrossJoinElementFactory CreatesdCrossJoinElementFactory();

        IsdtCrossJoinElementFactory CreatesdtCrossJoinElementFactory();

        IslCrossJoinElementFactory CreateslCrossJoinElementFactory();

        IslΛCrossJoinElementFactory CreateslΛCrossJoinElementFactory();

        IsrCrossJoinElementFactory CreatesrCrossJoinElementFactory();

        IsrdCrossJoinElementFactory CreatesrdCrossJoinElementFactory();

        IsrjCrossJoinElementFactory CreatesrjCrossJoinElementFactory();

        IsrtCrossJoinElementFactory CreatesrtCrossJoinElementFactory();

        IstCrossJoinElementFactory CreatestCrossJoinElementFactory();

        IsΛCrossJoinElementFactory CreatesΛCrossJoinElementFactory();

        ItΛCrossJoinElementFactory CreatetΛCrossJoinElementFactory();
    }
}