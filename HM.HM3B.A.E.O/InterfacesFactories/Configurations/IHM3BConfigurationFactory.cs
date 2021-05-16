namespace HM.HM3B.A.E.O.InterfacesFactories.Configurations
{
    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM3B.A.E.O.Interfaces.Configurations;

    public interface IHM3BConfigurationFactory
    {
        IHM3BConfiguration Create(
            Configuration configuration);
    }
}