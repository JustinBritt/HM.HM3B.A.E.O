namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioRecoveryWardUtilizations
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardUtilizations;

    internal sealed class VHatCalculation : IVHatCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VHatCalculation()
        {
        }

        public IVHat Calculate(
            INormalFactory normalFactory,
            IVHatResultElementFactory VHatResultElementFactory,
            IVHatFactory VHatFactory,
            IRNBCalculation RNBCalculation,
            ItStarCalculation tStarCalculation,
            IVHatResultElementCalculation VHatResultElementCalculation,
            It t,
            IΛ Λ,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI,
            Iυ2 υ2)
        {
            return VHatFactory.Create(
                Λ.Value.Values
                .Select(i => VHatResultElementCalculation.Calculate(
                    normalFactory,
                    VHatResultElementFactory,
                    RNBCalculation,
                    tStarCalculation,
                    i,
                    t,
                    expectedValueI,
                    varianceI,
                    υ2))
                .ToImmutableList());
        }
    }
}