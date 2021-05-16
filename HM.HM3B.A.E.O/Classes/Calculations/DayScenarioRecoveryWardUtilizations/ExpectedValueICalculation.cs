namespace HM.HM3B.A.E.O.Classes.Calculations.DayScenarioRecoveryWardUtilizations
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardUtilizations;

    internal sealed class ExpectedValueICalculation : IExpectedValueICalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueICalculation()
        {
        }

        public IExpectedValueI Calculate(
            IExpectedValueIResultElementFactory expectedValueIResultElementFactory,
            IExpectedValueIFactory expectedValueIFactory,
            IExpectedValueIResultElementCalculation expectedValueIResultElementCalculation,
            Il l,
            It t,
            Ist st,
            ItΛ tΛ,
            IExpectedValueΦ expectedValueΦ,
            Iz z)
        {
            return expectedValueIFactory.Create(
                tΛ.Value
                .Select(i => expectedValueIResultElementCalculation.Calculate(
                    expectedValueIResultElementFactory,
                    i.tIndexElement,
                    i.ΛIndexElement,
                    l,
                    t,
                    st,
                    expectedValueΦ,
                    z))
                .ToImmutableList());
        }
    }
}