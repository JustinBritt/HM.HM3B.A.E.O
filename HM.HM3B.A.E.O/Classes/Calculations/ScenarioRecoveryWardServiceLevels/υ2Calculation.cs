namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioRecoveryWardServiceLevels
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardServiceLevels;

    internal sealed class υ2Calculation : Iυ2Calculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ2Calculation()
        {
        }

        public Iυ2 Calculate(
            INormalFactory normalFactory,
            Iυ2ResultElementFactory υ2ResultElementFactory,
            Iυ2Factory υ2Factory,
            IMRNBCalculation MRNBCalculation,
            IRNBCalculation RNBCalculation,
            Iυ2ResultElementCalculation υ2ResultElementCalculation,
            It t,
            IΛ Λ,
            IΩ Ω,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI)
        {
            return υ2Factory.Create(
                Λ.Value
                .Select(i => υ2ResultElementCalculation.Calculate(
                    normalFactory,
                    υ2ResultElementFactory,
                    MRNBCalculation,
                    RNBCalculation,
                    i,
                    t,
                    Ω,
                    expectedValueI,
                    varianceI))
                .ToImmutableList());
        }
    }
}