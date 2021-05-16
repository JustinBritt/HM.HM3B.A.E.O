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

    internal sealed class VarianceICalculation : IVarianceICalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceICalculation()
        {
        }

        public IVarianceI Calculate(
            IVarianceIResultElementFactory varianceIResultElementFactory,
            IVarianceIFactory varianceIFactory,
            IVarianceIResultElementCalculation varianceIResultElementCalculation,
            Il l,
            It t,
            Ist st,
            ItΛ tΛ,
            IVarianceΦ varianceΦ,
            Iz z)
        {
            return varianceIFactory.Create(
                tΛ.Value
                .Select(i => varianceIResultElementCalculation.Calculate(
                    varianceIResultElementFactory,
                    i.tIndexElement,
                    i.ΛIndexElement,
                    l,
                    t,
                    st,
                    varianceΦ,
                    z))
                .ToImmutableList());
        }
    }
}