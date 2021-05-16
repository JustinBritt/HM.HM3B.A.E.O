namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;

    public interface ISurgeonScenarioNumberPatientsResultElementFactory
    {
        ISurgeonScenarioNumberPatientsResultElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            int value);
    }
}