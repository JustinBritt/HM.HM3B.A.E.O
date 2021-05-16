namespace HM.HM3B.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardUtilizations
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;

    public interface IExpectedValueIFactory
    {
        IExpectedValueI Create(
            ImmutableList<IExpectedValueIResultElement> value);
    }
}