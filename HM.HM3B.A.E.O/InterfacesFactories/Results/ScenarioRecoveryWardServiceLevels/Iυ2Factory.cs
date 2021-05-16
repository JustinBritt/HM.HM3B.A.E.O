namespace HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardServiceLevels
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;

    public interface Iυ2Factory
    {
        Iυ2 Create(
            ImmutableList<Iυ2ResultElement> value);
    }
}