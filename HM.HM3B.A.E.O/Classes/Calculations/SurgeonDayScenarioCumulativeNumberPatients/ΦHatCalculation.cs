namespace HM.HM3B.A.E.O.Classes.Calculations.SurgeonDayScenarioCumulativeNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ΦHatCalculation : IΦHatCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΦHatCalculation()
        {
        }

        public IΦHat Calculate(
            IExpectedValueIResultElementCalculationFactory expectedValueIResultElementCalculationFactory,
            IExpectedValueΦResultElementCalculationFactory expectedValueΦResultElementCalculationFactory,
            IVarianceIResultElementCalculationFactory varianceIResultElementCalculationFactory,
            IVarianceΦResultElementCalculationFactory varianceΦResultElementCalculationFactory,
            IVHatResultElementCalculationFactory VHatResultElementCalculationFactory,
            Iυ2ResultElementCalculationFactory υ2ResultElementCalculationFactory,
            IΦHatResultElementCalculationFactory ΦHatResultElementCalculationFactory,
            IExpectedValueICalculationFactory expectedValueICalculationFactory,
            IExpectedValueΦCalculationFactory expectedValueΦCalculationFactory,
            IMRNBCalculationFactory MRNBCalculationFactory,
            IRNBCalculationFactory RNBCalculationFactory,
            ItStarCalculationFactory tStarCalculationFactory,
            IVarianceICalculationFactory varianceICalculationFactory,
            IVarianceΦCalculationFactory varianceΦCalculationFactory,
            IVHatCalculationFactory VHatCalculationFactory,
            Iυ2CalculationFactory υ2CalculationFactory,
            INormalFactory normalFactory,
            IExpectedValueIResultElementFactory expectedValueIResultElementFactory,
            IExpectedValueΦResultElementFactory expectedValueΦResultElementFactory,
            IVarianceIResultElementFactory varianceIResultElementFactory,
            IVarianceΦResultElementFactory varianceΦResultElementFactory,
            IVHatResultElementFactory VHatResultElementFactory,
            Iυ2ResultElementFactory υ2ResultElementFactory,
            IΦHatResultElementFactory ΦHatResultElementFactory,
            IExpectedValueIFactory expectedValueIFactory,
            IExpectedValueΦFactory expectedValueΦFactory,
            IVarianceIFactory varianceIFactory,
            IVarianceΦFactory varianceΦFactory,
            IVHatFactory VHatFactory,
            Iυ2Factory υ2Factory,
            IΦHatFactory ΦHatFactory,
            Il l,
            Is s,
            It t,
            IΛ Λ,
            IslΛ slΛ,
            Ist st,
            ItΛ tΛ,
            IL L,
            Ip p,
            Iμ μ,
            Iσ σ,
            IΩ Ω,
            Iz z)
        {
            // ExpectedValueΦ
            IExpectedValueΦ expectedValueΦ = expectedValueΦCalculationFactory.Create()
                .Calculate(
                expectedValueΦResultElementFactory,
                expectedValueΦFactory,
                expectedValueΦResultElementCalculationFactory.Create(),
                l,
                s,
                t,
                Λ,
                slΛ,
                L,
                p,
                μ);

            // VarianceΦ
            IVarianceΦ varianceΦ = varianceΦCalculationFactory.Create()
                .Calculate(
                varianceΦResultElementFactory,
                varianceΦFactory,
                varianceΦResultElementCalculationFactory.Create(),
                l,
                t,
                slΛ,
                L,
                p,
                μ,
                σ);

            // ExpectedValueI
            IExpectedValueI expectedValueI = expectedValueICalculationFactory.Create()
                .Calculate(
                expectedValueIResultElementFactory,
                expectedValueIFactory,
                expectedValueIResultElementCalculationFactory.Create(),
                l,
                t,
                st,
                tΛ,
                expectedValueΦ,
                z);

            // VarianceI
            IVarianceI varianceI = varianceICalculationFactory.Create()
                .Calculate(
                varianceIResultElementFactory,
                varianceIFactory,
                varianceIResultElementCalculationFactory.Create(),
                l,
                t,
                st,
                tΛ,
                varianceΦ,
                z);

            // υ2
            Iυ2 υ2 = υ2CalculationFactory.Create()
                .Calculate(
                normalFactory,
                υ2ResultElementFactory,
                υ2Factory,
                MRNBCalculationFactory.Create(),
                RNBCalculationFactory.Create(),
                υ2ResultElementCalculationFactory.Create(),
                t,
                Λ,
                Ω,
                expectedValueI,
                varianceI);

            // VHat
            IVHat VHat = VHatCalculationFactory.Create()
                .Calculate(
                normalFactory,
                VHatResultElementFactory,
                VHatFactory,
                RNBCalculationFactory.Create(),
                tStarCalculationFactory.Create(),
                VHatResultElementCalculationFactory.Create(),
                t,
                Λ,
                expectedValueI,
                varianceI,
                υ2);

            return this.Calculate(
                normalFactory,
                ΦHatResultElementFactory,
                ΦHatFactory,
                ΦHatResultElementCalculationFactory.Create(),
                slΛ,
                expectedValueΦ,
                varianceΦ,
                VHat,
                υ2);
        }

        public IΦHat Calculate(
            INormalFactory normalFactory,
            IΦHatResultElementFactory ΦHatResultElementFactory,
            IΦHatFactory ΦHatFactory,
            IΦHatResultElementCalculation ΦHatResultElementCalculation,
            IslΛ slΛ,
            IExpectedValueΦ expectedValueΦ,
            IVarianceΦ varianceΦ,
            IVHat VHat,
            Iυ2 υ2)
        {
            return ΦHatFactory.Create(
                slΛ.Value
                .Select(i => ΦHatResultElementCalculation.Calculate(
                    normalFactory,
                    ΦHatResultElementFactory,
                    i.lIndexElement,
                    i.sIndexElement,
                    i.ΛIndexElement,
                    expectedValueΦ,
                    varianceΦ,
                    VHat,
                    υ2))
                .ToImmutableList());
        }
    }
}