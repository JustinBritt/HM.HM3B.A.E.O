namespace HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsFactory
    {
        IScenarioNumberPatients Create(
            ImmutableList<IScenarioNumberPatientsResultElement> value);
    }
}