namespace HM.HM3B.A.E.O.Classes.Calculations.DayScenarioExpectedBedShortages
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages;

    internal sealed class EBSResultElementCalculation : IEBSResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElementCalculation()
        {
        }

        public IEBSResultElement Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            IΩ Ω,
            IExpectedValueI ExpectedValueI,
            IVarianceI VarianceI)
        {
            int Ω_tΛ = Ω.Value.Value.Value;

            double ExpectedValueI_tΛ = (double)ExpectedValueI.GetElementAtAsdecimal(
                tIndexElement,
                ΛIndexElement);

            double VarianceI_tΛ = (double)VarianceI.GetElementAtAsdecimal(
                tIndexElement,
                ΛIndexElement);

            double lowerBound = Ω_tΛ + 0.5;

            double upperBound = double.PositiveInfinity;

            double value =
                0.5
                *
                (Ω_tΛ - ExpectedValueI_tΛ)
                *
                (MathNet.Numerics.SpecialFunctions.Erf(
                    (lowerBound - ExpectedValueI_tΛ)
                    *
                    Math.Pow(Math.Sqrt(2 * VarianceI_tΛ), -1))
                -
                MathNet.Numerics.SpecialFunctions.Erf(
                    (upperBound - ExpectedValueI_tΛ)
                    *
                    Math.Pow(Math.Sqrt(2 * VarianceI_tΛ), -1)))
                +
                Math.Sqrt(VarianceI_tΛ)
                *
                Math.Pow(Math.Sqrt(2 * Math.PI), -1)
                *
                (Math.Exp(
                    -Math.Pow(lowerBound - ExpectedValueI_tΛ, 2)
                    *
                    Math.Pow(2 * VarianceI_tΛ, -1))
                -
                Math.Exp(
                    -Math.Pow(upperBound - ExpectedValueI_tΛ, 2)
                    *
                    Math.Pow(2 * VarianceI_tΛ, -1)));

            return EBSResultElementFactory.Create(
                tIndexElement,
                ΛIndexElement,
                (decimal)value);
        }
    }
}