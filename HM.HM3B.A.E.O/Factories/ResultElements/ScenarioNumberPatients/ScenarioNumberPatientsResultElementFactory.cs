namespace HM.HM3B.A.E.O.Factories.ResultElements.ScenarioNumberPatients
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsResultElementFactory : IScenarioNumberPatientsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsResultElementFactory()
        {
        }

        public IScenarioNumberPatientsResultElement Create(
            IΛIndexElement ΛIndexElement,
            int value)
        {
            IScenarioNumberPatientsResultElement resultElement = null;

            try
            {
                resultElement = new ScenarioNumberPatientsResultElement(
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