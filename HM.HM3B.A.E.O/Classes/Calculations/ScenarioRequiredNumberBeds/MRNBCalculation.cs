namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioRequiredNumberBeds
{
    using System;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;

    internal sealed class MRNBCalculation : IMRNBCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MRNBCalculation()
        {
        }

        public int Calculate(
            INormalFactory normalFactory,
            IRNBCalculation RNBCalculation,
            IΛIndexElement ΛIndexElement,
            It t,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI,
            decimal υ2)
        {
            return (int)Math.Ceiling(
                t.Value
                .Select(i => RNBCalculation.Calculate(
                    normalFactory,
                    i,
                    ΛIndexElement,
                    expectedValueI,
                    varianceI,
                    υ2)) 
                .Max());
        }
    }
}