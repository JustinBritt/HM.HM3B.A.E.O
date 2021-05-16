namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioRecoveryWardServiceLevels
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRecoveryWardServiceLevels;

    internal sealed class υ2ResultElementCalculationFactory : Iυ2ResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ2ResultElementCalculationFactory()
        {
        }

        public Iυ2ResultElementCalculation Create()
        {
            Iυ2ResultElementCalculation calculation = null;

            try
            {
                calculation = new υ2ResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}