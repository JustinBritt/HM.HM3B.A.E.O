namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioTotalTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.TimeBlockLength;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesCalculation : IScenarioTotalTimesCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesCalculation()
        {
        }

        public IScenarioTotalTimes Calculate(
            IScenarioTotalTimesResultElementFactory scenarioTotalTimesResultElementFactory,
            IScenarioTotalTimesFactory scenarioTotalTimesFactory,
            IScenarioTotalTimesResultElementCalculation scenarioTotalTimesResultElementCalculation,
            IΛ Λ,
            Isrt srt,
            IH H,
            Ix x)
        {
            return scenarioTotalTimesFactory.Create(
                Λ.Value.Values
                .Select(w => scenarioTotalTimesResultElementCalculation.Calculate(
                    scenarioTotalTimesResultElementFactory,
                    w,
                    srt,
                    H,
                    x))
                .ToImmutableList());
        }
    }
}