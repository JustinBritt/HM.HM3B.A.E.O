namespace HM.HM3B.A.E.O.Classes.Configurations
{
    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM3B.A.E.O.Interfaces.Configurations;

    internal sealed class HM3BConfiguration : IHM3BConfiguration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BConfiguration(
            Configuration configuration)
        {
            this.Value = configuration;
        }

        public Configuration Value { get; }
    }
}