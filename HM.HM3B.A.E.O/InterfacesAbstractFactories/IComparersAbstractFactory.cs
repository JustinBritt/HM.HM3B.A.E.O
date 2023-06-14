namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Comparers;

    public interface IComparersAbstractFactory
    {
        IDeviceComparerFactory CreateDeviceComparerFactory();

        ILocationComparerFactory CreateLocationComparerFactory();

        IOrganizationComparerFactory CreateOrganizationComparerFactory();
    }
}