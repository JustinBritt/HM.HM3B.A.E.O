namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsCalculation : IScenarioNumberPatientsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsCalculation()
        {
        }

        public IScenarioNumberPatients Calculate(
            IScenarioNumberPatientsResultElementFactory scenarioNumberPatientsResultElementFactory,
            IScenarioNumberPatientsFactory scenarioNumberPatientsFactory,
            IScenarioNumberPatientsResultElementCalculation scenarioNumberPatientsResultElementCalculation,
            IΛ Λ,
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients)
        {
            return scenarioNumberPatientsFactory.Create(
                Λ.Value
                    .Select(i => scenarioNumberPatientsResultElementCalculation.Calculate(
                        scenarioNumberPatientsResultElementFactory,
                        i,
                        surgeonScenarioNumberPatients))
                    .ToImmutableList());
        }
    }
}