namespace HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonDayScenarioCumulativeNumberPatients
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IΦHatResultElementCalculation
    {
        IΦHatResultElement Calculate(
            INormalFactory normalFactory,
            IΦHatResultElementFactory ΦHatResultElementFactory,
            IlIndexElement lIndexElement,
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            IExpectedValueΦ expectedValueΦ,
            IVarianceΦ varianceΦ,
            IVHat VHat,
            Iυ2 υ2);
    }
}