namespace HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRecoveryWardServiceLevels
{
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardServiceLevels;

    public interface Iυ2ResultElementCalculation
    {
        Iυ2ResultElement Calculate(
            INormalFactory normalFactory,
            Iυ2ResultElementFactory υ2ResultElementFactory,
            IMRNBCalculation MRNBCalculation,
            IRNBCalculation RNBCalculation,
            IΛIndexElement ΛIndexElement,
            It t,
            IΩ Ω,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI);
    }
}