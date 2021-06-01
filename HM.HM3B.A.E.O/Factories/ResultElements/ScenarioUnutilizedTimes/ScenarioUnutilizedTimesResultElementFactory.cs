namespace HM.HM3B.A.E.O.Factories.ResultElements.ScenarioUnutilizedTimes
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;

    internal sealed class ScenarioUnutilizedTimesResultElementFactory : IScenarioUnutilizedTimesResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesResultElementFactory()
        {
        }

        public IScenarioUnutilizedTimesResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            IScenarioUnutilizedTimesResultElement resultElement = null;

            try
            {
                resultElement = new ScenarioUnutilizedTimesResultElement(
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