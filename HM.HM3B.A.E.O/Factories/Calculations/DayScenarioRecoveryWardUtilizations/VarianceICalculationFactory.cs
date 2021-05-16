namespace HM.HM3B.A.E.O.Factories.Calculations.DayScenarioRecoveryWardUtilizations
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.DayScenarioRecoveryWardUtilizations;

    internal sealed class VarianceICalculationFactory : IVarianceICalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceICalculationFactory()
        {
        }

        public IVarianceICalculation Create()
        {
            IVarianceICalculation calculation = null;

            try
            {
                calculation = new VarianceICalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}