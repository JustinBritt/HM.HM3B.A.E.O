namespace HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardUtilizations
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardUtilizations;

    public interface IVHatFactory
    {
        IVHat Create(
            ImmutableList<IVHatResultElement> value);
    }
}