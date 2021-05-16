namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioRecoveryWardUtilizations
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardUtilizations;

    internal sealed class VHatResultElementCalculation : IVHatResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VHatResultElementCalculation()
        {
        }

        public IVHatResultElement Calculate(
            INormalFactory normalFactory,
            IVHatResultElementFactory VHatResultElementFactory,
            IRNBCalculation RNBCalculation,
            ItStarCalculation tStarCalculation,
            IΛIndexElement ΛIndexElement,
            It t,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI,
            Iυ2 υ2)
        {
            return VHatResultElementFactory.Create(
                ΛIndexElement,
                varianceI.GetElementAtAsdecimal(
                    tStarCalculation.Calculate(
                        normalFactory,
                        RNBCalculation,
                        ΛIndexElement,
                        t,
                        expectedValueI,
                        varianceI,
                        υ2),
                    ΛIndexElement));
        }
    }
}