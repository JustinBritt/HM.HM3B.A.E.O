namespace HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;

    public interface IScenarioUnutilizedTimesFactory
    {
        IScenarioUnutilizedTimes Create(
            ImmutableList<IScenarioUnutilizedTimesResultElement> value);
    }
}