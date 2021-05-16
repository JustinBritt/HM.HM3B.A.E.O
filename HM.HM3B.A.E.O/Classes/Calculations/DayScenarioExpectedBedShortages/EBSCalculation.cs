namespace HM.HM3B.A.E.O.Classes.Calculations.DayScenarioExpectedBedShortages
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.DayScenarioExpectedBedShortages;

    internal sealed class EBSCalculation : IEBSCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSCalculation()
        {
        }

        public IEBS Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            IEBSFactory EBSFactory,
            IEBSResultElementCalculation EBSResultElementCalculation,
            ItΛ tΛ,
            IΩ Ω,
            IExpectedValueI ExpectedValueI,
            IVarianceI VarianceI)
        {
            return EBSFactory.Create(
                tΛ.Value
                .Select(w => EBSResultElementCalculation.Calculate(
                    EBSResultElementFactory,
                    w.tIndexElement,
                    w.ΛIndexElement,
                    Ω,
                    ExpectedValueI,
                    VarianceI))
                .ToImmutableList());
        }
    }
}