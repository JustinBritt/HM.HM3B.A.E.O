namespace HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioExpectedBedShortages
{
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.DayScenarioExpectedBedShortages;

    public interface IEBSCalculation
    {
        IEBS Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            IEBSFactory EBSFactory,
            IEBSResultElementCalculation EBSResultElementCalculation,
            ItΛ tΛ,
            IΩ Ω,
            IExpectedValueI ExpectedValueI,
            IVarianceI VarianceI);
    }
}