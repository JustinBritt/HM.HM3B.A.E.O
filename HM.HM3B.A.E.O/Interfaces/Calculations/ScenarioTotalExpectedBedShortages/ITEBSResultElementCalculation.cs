namespace HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioTotalExpectedBedShortages
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;

    public interface ITEBSResultElementCalculation
    {
        ITEBSResultElement Calculate(
            ITEBSResultElementFactory TEBSResultElementFactory,
            IΛIndexElement ΛIndexElement,
            It t,
            IEBS EBS);
    }
}