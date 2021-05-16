namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioUnderutilizations
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsCalculation : IScenarioUnderutilizationsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsCalculation()
        {
        }

        public IScenarioUnderutilizations Calculate(
            IScenarioUnderutilizationsResultElementFactory scenarioUnderutilizationsResultElementFactory,
            IScenarioUnderutilizationsFactory scenarioUnderutilizationsFactory,
            IScenarioUnderutilizationsResultElementCalculation scenarioUnderutilizationsResultElementCalculation,
            IΛ Λ,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUnutilizedTimes scenarioUnutilizedTimes)
        {
            return scenarioUnderutilizationsFactory.Create(
                Λ.Value
                .Select(w => scenarioUnderutilizationsResultElementCalculation.Calculate(
                    scenarioUnderutilizationsResultElementFactory,
                    w,
                    scenarioTotalTimes,
                    scenarioUnutilizedTimes))
                .ToImmutableList());
        }
    }
}