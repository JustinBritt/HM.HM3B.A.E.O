namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;

    public interface IScenarioUnderutilizationsResultElementFactory
    {
        IScenarioUnderutilizationsResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}