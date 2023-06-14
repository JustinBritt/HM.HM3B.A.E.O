namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioUnutilizedTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes;
    
    internal sealed class ScenarioUnutilizedTimesCalculation : IScenarioUnutilizedTimesCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesCalculation()
        {
        }

        public IScenarioUnutilizedTimes Calculate(
            IScenarioUnutilizedTimesResultElementFactory scenarioUnutilizedTimesResultElementFactory,
            IScenarioUnutilizedTimesFactory scenarioUnutilizedTimesFactory,
            IScenarioUnutilizedTimesResultElementCalculation scenarioUnutilizedTimesResultElementCalculation,
            IΛ Λ,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUtilizedTimes scenarioUtilizedTimes)
        {
            return scenarioUnutilizedTimesFactory.Create(
                Λ.Value.Values
                .Select(w => scenarioUnutilizedTimesResultElementCalculation.Calculate(
                    scenarioUnutilizedTimesResultElementFactory,
                    w,
                    scenarioTotalTimes,
                    scenarioUtilizedTimes))
                .ToImmutableList());
        }
    }
}