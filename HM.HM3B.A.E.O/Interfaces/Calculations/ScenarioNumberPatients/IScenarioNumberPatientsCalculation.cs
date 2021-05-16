namespace HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioNumberPatients
{
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsCalculation
    {
        IScenarioNumberPatients Calculate(
            IScenarioNumberPatientsResultElementFactory scenarioNumberPatientsResultElementFactory,
            IScenarioNumberPatientsFactory scenarioNumberPatientsFactory,
            IScenarioNumberPatientsResultElementCalculation scenarioNumberPatientsResultElementCalculation,
            IΛ Λ,
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients);
    }
}