namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Exports;

    public interface IExportsAbstractFactory
    {
        IHM3BExportFactory CreateHM3BExportFactory();
    }
}