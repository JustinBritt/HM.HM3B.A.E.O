namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioTotalExpectedBedShortages
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioTotalExpectedBedShortages;

    internal sealed class TEBSCalculation : ITEBSCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSCalculation()
        {
        }

        public ITEBS Calculate(
            ITEBSResultElementFactory TEBSResultElementFactory,
            ITEBSFactory TEBSFactory,
            ITEBSResultElementCalculation TEBSResultElementCalculation,
            It t,
            IΛ Λ,
            IEBS EBS)
        {
            return TEBSFactory.Create(
                Λ.Value
                .Select(w => TEBSResultElementCalculation.Calculate(
                    TEBSResultElementFactory,
                    w,
                    t,
                    EBS))
                .ToImmutableList());
        }
    }
}