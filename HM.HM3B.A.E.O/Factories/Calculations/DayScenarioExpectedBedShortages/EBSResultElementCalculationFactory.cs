namespace HM.HM3B.A.E.O.Factories.Calculations.DayScenarioExpectedBedShortages
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.DayScenarioExpectedBedShortages;

    internal sealed class EBSResultElementCalculationFactory : IEBSResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElementCalculationFactory()
        {
        }

        public IEBSResultElementCalculation Create()
        {
            IEBSResultElementCalculation calculation = null;

            try
            {
                calculation = new EBSResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}