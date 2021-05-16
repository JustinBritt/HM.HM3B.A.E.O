namespace HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;

    public interface IRNBCalculation
    {
        decimal Calculate(
            INormalFactory normalFactory,
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI,
            decimal υ2);
    }
}