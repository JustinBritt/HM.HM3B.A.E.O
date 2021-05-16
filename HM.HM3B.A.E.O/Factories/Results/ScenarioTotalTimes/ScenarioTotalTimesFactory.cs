namespace HM.HM3B.A.E.O.Factories.Results.ScenarioTotalTimes
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesFactory : IScenarioTotalTimesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesFactory()
        {
        }

        public IScenarioTotalTimes Create(
            ImmutableList<IScenarioTotalTimesResultElement> value)
        {
            IScenarioTotalTimes result = null;

            try
            {
                result = new ScenarioTotalTimes(
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