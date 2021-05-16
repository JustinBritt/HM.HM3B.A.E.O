namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Solutions;

    public interface ISolutionsAbstractFactory
    {
        IHM3BSolutionFactory CreateHM3BSolutionFactory();
    }
}