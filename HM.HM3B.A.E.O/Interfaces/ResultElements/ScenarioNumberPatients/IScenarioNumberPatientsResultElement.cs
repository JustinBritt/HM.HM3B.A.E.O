namespace HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IScenarioNumberPatientsResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        int Value { get; }
    }
}