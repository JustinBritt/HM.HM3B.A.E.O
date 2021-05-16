namespace HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioNumberPatients
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsResultElementCalculation
    {
        IScenarioNumberPatientsResultElement Calculate(
            IScenarioNumberPatientsResultElementFactory scenarioNumberPatientsResultElementFactory,
            IΛIndexElement ΛIndexElement,
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients);
    }
}