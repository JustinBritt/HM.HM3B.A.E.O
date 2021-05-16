namespace HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardServiceLevels;

    public interface Iυ2
    {
        ImmutableList<Iυ2ResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IΛIndexElement ΛIndexElement);
    }
}