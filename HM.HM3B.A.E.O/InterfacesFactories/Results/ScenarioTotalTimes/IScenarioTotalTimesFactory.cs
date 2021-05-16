namespace HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;

    public interface IScenarioTotalTimesFactory
    {
        IScenarioTotalTimes Create(
            ImmutableList<IScenarioTotalTimesResultElement> value);
    }
}