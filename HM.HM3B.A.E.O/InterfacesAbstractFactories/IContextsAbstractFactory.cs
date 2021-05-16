namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;

    public interface IContextsAbstractFactory
    {
        IHM3BInputContextFactory CreateHM3BInputContextFactory();

        IHM3BOutputContextFactory CreateHM3BOutputContextFactory();
    }
}