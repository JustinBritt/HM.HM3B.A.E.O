namespace HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRecoveryWardUtilizations
{
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardUtilizations;

    public interface IVHatResultElementCalculation
    {
        IVHatResultElement Calculate(
            INormalFactory normalFactory,
            IVHatResultElementFactory VHatResultElementFactory,
            IRNBCalculation RNBCalculation,
            ItStarCalculation tStarCalculation,
            IΛIndexElement ΛIndexElement,
            It t,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI,
            Iυ2 υ2);
    }
}