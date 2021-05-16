namespace HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IScenarioUnderutilizationsResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}