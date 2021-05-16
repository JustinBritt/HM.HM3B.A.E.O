namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioUnderutilizations
{
    using System.Linq;
  
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsResultElementCalculation : IScenarioUnderutilizationsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsResultElementCalculation()
        {
        }

        public IScenarioUnderutilizationsResultElement Calculate(
            IScenarioUnderutilizationsResultElementFactory scenarioUnderutilizationsResultElementFactory,
            IΛIndexElement ΛIndexElement,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUnutilizedTimes scenarioUnutilizedTimes)
        {
            return scenarioUnderutilizationsResultElementFactory.Create(
                ΛIndexElement,
                scenarioUnutilizedTimes.Value.Where(w => w.ΛIndexElement == ΛIndexElement).Select(w => w.Value).SingleOrDefault() 
                /
                scenarioTotalTimes.Value.Where(w => w.ΛIndexElement == ΛIndexElement).Select(w => w.Value).SingleOrDefault());
        }
    }
}