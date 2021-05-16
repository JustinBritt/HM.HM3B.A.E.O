namespace HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardUtilizations
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardUtilizations;

    public interface IVHat
    {
        ImmutableList<IVHatResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IΛIndexElement ΛIndexElement);
    }
}