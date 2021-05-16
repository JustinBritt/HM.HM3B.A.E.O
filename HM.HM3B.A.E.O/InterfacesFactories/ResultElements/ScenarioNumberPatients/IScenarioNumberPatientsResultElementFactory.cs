namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsResultElementFactory
    {
        IScenarioNumberPatientsResultElement Create(
            IΛIndexElement ΛIndexElement,
            int value);
    }
}