namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioRequiredNumberBeds
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;

    internal sealed class RNBCalculation : IRNBCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RNBCalculation()
        {
        }

        public decimal Calculate(
            INormalFactory normalFactory,
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI,
            decimal υ2)
        {
            // https://stackoverflow.com/questions/1662943/standard-normal-distribution-z-value-function-in-c-sharp
            MathNet.Numerics.Distributions.Normal normal = (MathNet.Numerics.Distributions.Normal)normalFactory.Create();

            return
                (decimal)expectedValueI.GetElementAtAsdecimal(
                    tIndexElement,
                    ΛIndexElement)
                +
                (decimal)normal.CumulativeDistribution((double)(1 - υ2))
                *
                (decimal)Math.Sqrt(
                    (double)varianceI.GetElementAtAsdecimal(
                        tIndexElement,
                        ΛIndexElement));             
        }
    }
}