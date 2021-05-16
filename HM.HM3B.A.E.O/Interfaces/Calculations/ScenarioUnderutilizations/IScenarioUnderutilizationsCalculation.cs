namespace HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations
{
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations;

    public interface IScenarioUnderutilizationsCalculation
    {
        IScenarioUnderutilizations Calculate(
            IScenarioUnderutilizationsResultElementFactory scenarioUnderutilizationsResultElementFactory,
            IScenarioUnderutilizationsFactory scenarioUnderutilizationsFactory,
            IScenarioUnderutilizationsResultElementCalculation scenarioUnderutilizationsResultElementCalculation,
            IΛ Λ,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUnutilizedTimes scenarioUnutilizedTimes);
    }
}