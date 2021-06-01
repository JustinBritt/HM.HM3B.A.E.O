namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioRecoveryWardServiceLevels
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRecoveryWardServiceLevels;

    internal sealed class υ2CalculationFactory : Iυ2CalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ2CalculationFactory()
        {
        }

        public Iυ2Calculation Create()
        {
            Iυ2Calculation calculation = null;

            try
            {
                calculation = new υ2Calculation();
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