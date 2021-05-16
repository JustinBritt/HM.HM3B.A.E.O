namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioRecoveryWardServiceLevels
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardServiceLevels;

    internal sealed class υ2ResultElementCalculation : Iυ2ResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ2ResultElementCalculation()
        {
        }

        public Iυ2ResultElement Calculate(
            INormalFactory normalFactory,
            Iυ2ResultElementFactory υ2ResultElementFactory,
            IMRNBCalculation MRNBCalculation,
            IRNBCalculation RNBCalculation,
            IΛIndexElement ΛIndexElement,
            It t,
            IΩ Ω,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI)
        {
            int MRNB = 0;

            decimal υ2 = 0;

            do
            {
                MRNB = MRNBCalculation.Calculate(
                    normalFactory,
                    RNBCalculation,
                    ΛIndexElement,
                    t,
                    expectedValueI,
                    varianceI,
                    υ2);

                υ2 = (decimal)υ2 + (decimal)0.01;
            } while (MRNB <= Ω.Value.Value.Value && υ2 <= 1);

            return υ2ResultElementFactory.Create(
                ΛIndexElement,
                υ2 - (decimal)0.01); // Subtract 0.01 to account for last iteration of the do-while loop
        }
    }
}