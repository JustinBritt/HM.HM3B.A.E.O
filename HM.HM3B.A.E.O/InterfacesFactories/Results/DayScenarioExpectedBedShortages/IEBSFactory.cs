namespace HM.HM3B.A.E.O.InterfacesFactories.Results.DayScenarioExpectedBedShortages
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;

    public interface IEBSFactory
    {
        IEBS Create(
            ImmutableList<IEBSResultElement> value);
    }
}