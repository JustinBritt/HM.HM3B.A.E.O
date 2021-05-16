namespace HM.HM3B.A.E.O.Classes.Calculations.SurgeonDayScenarioCumulativeNumberPatients
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ΦHatResultElementCalculation : IΦHatResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΦHatResultElementCalculation()
        {
        }

        public IΦHatResultElement Calculate(
            INormalFactory normalFactory,
            IΦHatResultElementFactory ΦHatResultElementFactory,
            IlIndexElement lIndexElement,
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            IExpectedValueΦ expectedValueΦ,
            IVarianceΦ varianceΦ,
            IVHat VHat,
            Iυ2 υ2)
        {
            // https://stackoverflow.com/questions/1662943/standard-normal-distribution-z-value-function-in-c-sharp
            MathNet.Numerics.Distributions.Normal normal = (MathNet.Numerics.Distributions.Normal)normalFactory.Create();

            return ΦHatResultElementFactory.Create(
                sIndexElement,
                lIndexElement,
                ΛIndexElement,
                (decimal)expectedValueΦ.GetElementAtAsdecimal(
                    sIndexElement,
                    lIndexElement,
                    ΛIndexElement)
                +
                (decimal)normal.CumulativeDistribution(
                    (double)(1 - υ2.GetElementAtAsdecimal(
                    ΛIndexElement)))
                *
                (decimal)Math.Pow(
                    Math.Sqrt(
                    (double)VHat.GetElementAtAsdecimal(
                        ΛIndexElement)),
                    -1)
                *
               (decimal)varianceΦ.GetElementAtAsdecimal(
                   sIndexElement,
                   lIndexElement,
                   ΛIndexElement));
        }
    }
}