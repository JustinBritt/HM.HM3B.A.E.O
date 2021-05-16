namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioTotalExpectedBedShortages
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;

    internal sealed class TEBSResultElementCalculation : ITEBSResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSResultElementCalculation()
        {
        }

        public ITEBSResultElement Calculate(
            ITEBSResultElementFactory TEBSResultElementFactory,
            IΛIndexElement ΛIndexElement,
            It t,
            IEBS EBS)
        {
            return TEBSResultElementFactory.Create(
                ΛIndexElement,
                t.Value
                .Select(w => EBS.GetElementAtAsdecimal(
                    w,
                    ΛIndexElement))
                .ToImmutableList()
                .Sum());
        }
    }
}