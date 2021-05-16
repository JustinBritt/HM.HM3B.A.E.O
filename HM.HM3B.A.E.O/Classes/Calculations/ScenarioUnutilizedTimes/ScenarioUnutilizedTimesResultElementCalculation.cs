namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioUnutilizedTimes
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;

    internal sealed class ScenarioUnutilizedTimesResultElementCalculation : IScenarioUnutilizedTimesResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesResultElementCalculation()
        {
        }

        public IScenarioUnutilizedTimesResultElement Calculate(
            IScenarioUnutilizedTimesResultElementFactory scenarioUnutilizedTimesResultElementFactory,
            IΛIndexElement ΛIndexElement,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUtilizedTimes scenarioUtilizedTimes)
        {
            return scenarioUnutilizedTimesResultElementFactory.Create(
                ΛIndexElement,
                scenarioTotalTimes.GetElementAtAsdecimal(
                    ΛIndexElement)
                -
                scenarioUtilizedTimes.GetElementAtAsdecimal(
                    ΛIndexElement));
        }
    }
}