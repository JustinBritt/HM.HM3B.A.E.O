namespace HM.HM3B.A.E.O.Factories.Calculations.DayScenarioRecoveryWardUtilizations
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.DayScenarioRecoveryWardUtilizations;

    internal sealed class ExpectedValueICalculationFactory : IExpectedValueICalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueICalculationFactory()
        {
        }

        public IExpectedValueICalculation Create()
        {
            IExpectedValueICalculation calculation = null;

            try
            {
                calculation = new ExpectedValueICalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return calculation;
        }
    }
}