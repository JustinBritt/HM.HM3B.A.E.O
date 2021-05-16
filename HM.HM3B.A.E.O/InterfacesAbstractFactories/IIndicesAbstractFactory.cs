namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Indices;

    public interface IIndicesAbstractFactory
    {
        IdFactory CreatedFactory();

        IjFactory CreatejFactory();

        IlFactory CreatelFactory();

        ImFactory CreatemFactory();

        IrFactory CreaterFactory();

        IsFactory CreatesFactory();

        ItFactory CreatetFactory();

        IΛFactory CreateΛFactory();
    }
}