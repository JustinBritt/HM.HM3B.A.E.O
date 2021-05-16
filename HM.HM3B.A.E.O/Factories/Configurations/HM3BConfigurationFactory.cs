namespace HM.HM3B.A.E.O.Factories.Configurations
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM3B.A.E.O.Classes.Configurations;
    using HM.HM3B.A.E.O.Interfaces.Configurations;
    using HM.HM3B.A.E.O.InterfacesFactories.Configurations;

    internal sealed class HM3BConfigurationFactory : IHM3BConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BConfigurationFactory()
        {
        }

        public IHM3BConfiguration Create(
            Configuration configuration)
        {
            IHM3BConfiguration HM3BConfiguration = null;

            try
            {
                HM3BConfiguration = new HM3BConfiguration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return HM3BConfiguration;
        }
    }
}