namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Configurations;

    public interface IConfigurationsAbstractFactory
    {
        IHM3BConfigurationFactory CreateHM3BConfigurationFactory();
    }
}