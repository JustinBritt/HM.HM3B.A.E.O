namespace HM.HM3B.A.E.O.Factories.ResultElements.ScenarioRecoveryWardUtilizations
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardUtilizations;

    internal sealed class VHatResultElementFactory : IVHatResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VHatResultElementFactory()
        {
        }

        public IVHatResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            IVHatResultElement resultElement = null;

            try
            {
                resultElement = new VHatResultElement(
                    ΛIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}