namespace HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioTotalTimes
{
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.TimeBlockLength;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes;

    public interface IScenarioTotalTimesCalculation
    {
        IScenarioTotalTimes Calculate(
            IScenarioTotalTimesResultElementFactory scenarioTotalTimesResultElementFactory,
            IScenarioTotalTimesFactory scenarioTotalTimesFactory,
            IScenarioTotalTimesResultElementCalculation scenarioTotalTimesResultElementCalculation,
            IΛ Λ,
            Isrt srt,
            IH H,
            Ix x);
    }
}