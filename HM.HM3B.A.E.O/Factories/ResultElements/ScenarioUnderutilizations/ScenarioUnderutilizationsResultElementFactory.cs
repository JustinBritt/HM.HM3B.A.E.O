namespace HM.HM3B.A.E.O.Factories.ResultElements.ScenarioUnderutilizations
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsResultElementFactory : IScenarioUnderutilizationsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsResultElementFactory()
        {
        }

        public IScenarioUnderutilizationsResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            IScenarioUnderutilizationsResultElement resultElement = null;

            try
            {
                resultElement = new ScenarioUnderutilizationsResultElement(
                    ΛIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}