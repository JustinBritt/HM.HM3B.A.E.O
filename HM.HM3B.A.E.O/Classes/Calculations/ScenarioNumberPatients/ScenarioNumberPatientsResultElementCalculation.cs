namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioNumberPatients
{
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsResultElementCalculation : IScenarioNumberPatientsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsResultElementCalculation()
        {
        }

        public IScenarioNumberPatientsResultElement Calculate(
            IScenarioNumberPatientsResultElementFactory scenarioNumberPatientsResultElementFactory,
            IΛIndexElement ΛIndexElement,
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients)
        {
            return scenarioNumberPatientsResultElementFactory.Create(
                ΛIndexElement,
                surgeonScenarioNumberPatients
                .GetElementsAt(
                    ΛIndexElement)
                .Select(w => w.Value)
                .Sum());
        }
    }
}