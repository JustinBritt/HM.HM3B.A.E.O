namespace HM.HM3B.A.E.O.Classes.Calculations.SurgeonDayScenarioCumulativeNumberPatients
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class VarianceΦResultElementCalculation : IVarianceΦResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceΦResultElementCalculation()
        {
        }

        public IVarianceΦResultElement Calculate(
            IVarianceΦResultElementFactory varianceΦResultElementFactory,
            IlIndexElement lIndexElement,
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            IL L,
            Ip p,
            Iμ μ,
            Iσ σ)
        {
            int Ls = L.GetElementAtAsint(
                sIndexElement);

            int τLowerBound = 0;

            int τUpperBound = (int)Math.Floor(
                (decimal)
                (Ls - lIndexElement.Value.Value.Value)
                /
                t.GetT());

            // Mean
            decimal meanSum = 0;

            for (int τ = τLowerBound; τ <= τUpperBound; τ = τ + 1)
            {
                int lPrimeLowerBound = lIndexElement.Value.Value.Value + τ * t.GetT() + 1;

                int lPrimeVarianceUpperBound = Math.Min(
                    lIndexElement.Value.Value.Value + τ * t.GetT() + t.GetT(),
                    Ls);

                int lPrimeCovarianceUpperBound = Math.Min(
                    lIndexElement.Value.Value.Value + τ * t.GetT() + t.GetT(),
                    Ls - 1);

                // Mean: Variance
                for (int lPrime = lPrimeLowerBound; lPrime <= lPrimeVarianceUpperBound; lPrime = lPrime + 1)
                {
                    meanSum +=
                        (τ + 1)
                        *
                        p.GetElementAtAsdecimal(
                            sIndexElement,
                            l.GetElementAt(
                                lPrime),
                            ΛIndexElement)
                        *
                        (1 - p.GetElementAtAsdecimal(
                            sIndexElement,
                            l.GetElementAt(
                                lPrime),
                            ΛIndexElement));
                }

                // Mean: Covariance
                for (int lPrime = lPrimeLowerBound; lPrime <= lPrimeCovarianceUpperBound; lPrime = lPrime + 1)
                {
                    int lHatLowerBound = lPrime + 1;

                    int lHatUpperBound = Ls;

                    for (int lHat = lHatLowerBound; lHat <= lHatUpperBound; lHat = lHat + 1)
                    {
                        meanSum -=
                            (τ + 1)
                            *
                            2
                            *
                            p.GetElementAtAsdecimal(
                                sIndexElement,
                                l.GetElementAt(
                                    lPrime),
                                ΛIndexElement)
                            *
                            p.GetElementAtAsdecimal(
                                sIndexElement,
                                l.GetElementAt(
                                    lHat),
                                ΛIndexElement);
                    }
                }
            }

            // Variance
            decimal varianceSum = 0;

            for (int τ = τLowerBound; τ <= τUpperBound; τ = τ + 1)
            {
                int lPrimeLowerBound = lIndexElement.Value.Value.Value + τ * t.GetT() + 1;

                int lPrimeUpperBound = Ls;

                for (int lPrime = lPrimeLowerBound; lPrime <= lPrimeUpperBound; lPrime = lPrime + 1)
                {
                    varianceSum +=
                        p.GetElementAtAsdecimal(
                            sIndexElement,
                            l.GetElementAt(
                                lPrime),
                            ΛIndexElement);
                }
            }

            return varianceΦResultElementFactory.Create(
                sIndexElement,
                lIndexElement,
                ΛIndexElement,
                μ.GetElementAtAsdecimal(
                    sIndexElement,
                    ΛIndexElement)
                *
                meanSum 
                +
                σ.GetElementAtAsdecimal(
                    sIndexElement,
                    ΛIndexElement)
                *
                σ.GetElementAtAsdecimal(
                    sIndexElement,
                    ΛIndexElement)
                *
                varianceSum
                *
                varianceSum);
        }
    }
}