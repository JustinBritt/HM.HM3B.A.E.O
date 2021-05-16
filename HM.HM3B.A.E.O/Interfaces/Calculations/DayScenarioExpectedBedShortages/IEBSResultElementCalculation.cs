namespace HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioExpectedBedShortages
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages;

    public interface IEBSResultElementCalculation
    {
        IEBSResultElement Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            IΩ Ω,
            IExpectedValueI ExpectedValueI,
            IVarianceI VarianceI);
    }
}