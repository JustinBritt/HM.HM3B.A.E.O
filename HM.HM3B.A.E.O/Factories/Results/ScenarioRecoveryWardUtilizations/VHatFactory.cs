namespace HM.HM3B.A.E.O.Factories.Results.ScenarioRecoveryWardUtilizations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardUtilizations;

    internal sealed class VHatFactory : IVHatFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VHatFactory()
        {
        }

        public IVHat Create(
            ImmutableList<IVHatResultElement> value)
        {
            IVHat result = null;

            try
            {
                result = new VHat(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}