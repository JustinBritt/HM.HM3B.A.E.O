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

    internal sealed class ExpectedValueΦResultElementCalculation : IExpectedValueΦResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueΦResultElementCalculation()
        {
        }

        public IExpectedValueΦResultElement Calculate(
            IExpectedValueΦResultElementFactory expectedValueΦResultElementFactory,
            IlIndexElement lIndexElement,
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            IL L,
            Ip p,
            Iμ μ)
        {
            int Ls = L.GetElementAtAsint(
                sIndexElement);

            int τLowerBound = 0;

            int τUpperBound = (int)Math.Floor(
                (decimal)
                (Ls - lIndexElement.Value.Value.Value)
                /
                t.GetT());

            decimal sum = 0;

            for (int τ = τLowerBound; τ <= τUpperBound; τ = τ + 1)
            {
                int lPrimeLowerBound = lIndexElement.Value.Value.Value + τ * t.GetT() + 1;

                int lPrimeUpperBound = Ls;

                for (int lPrime = lPrimeLowerBound; lPrime <= lPrimeUpperBound; lPrime = lPrime + 1)
                {
                    sum +=
                        p.GetElementAtAsdecimal(
                            sIndexElement,
                            l.GetElementAt(
                                lPrime),
                            ΛIndexElement);
                }
            }

            return expectedValueΦResultElementFactory.Create(
                sIndexElement,
                lIndexElement,
                ΛIndexElement,
                μ.GetElementAtAsdecimal(
                    sIndexElement,
                    ΛIndexElement)
                *
                sum);
        }
    }
}