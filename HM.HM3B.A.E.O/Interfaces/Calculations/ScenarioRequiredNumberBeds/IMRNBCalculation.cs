namespace HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;

    public interface IMRNBCalculation
    {
        int Calculate(
            INormalFactory normalFactory,
            IRNBCalculation RNBCalculation,
            IΛIndexElement ΛIndexElement,
            It t,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI,
            decimal υ2);
    }
}