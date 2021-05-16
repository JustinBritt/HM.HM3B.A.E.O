namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoins;

    public interface ICrossJoinsAbstractFactory
    {
        IdtFactory CreatedtFactory();

        ImrFactory CreatemrFactory();

        IrtFactory CreatertFactory();

        IsdFactory CreatesdFactory();

        IsdtFactory CreatesdtFactory();

        IslFactory CreateslFactory();

        IslΛFactory CreateslΛFactory();

        IsrFactory CreatesrFactory();

        IsrdFactory CreatesrdFactory();

        IsrjFactory CreatesrjFactory();

        IsrtFactory CreatesrtFactory();

        IstFactory CreatestFactory();

        IsΛFactory CreatesΛFactory();

        ItΛFactory CreatetΛFactory();
    }
}