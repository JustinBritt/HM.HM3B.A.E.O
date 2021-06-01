namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioTotalExpectedBedShortages
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages;

    internal sealed class TEBSCalculationFactory : ITEBSCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSCalculationFactory()
        {
        }

        public ITEBSCalculation Create()
        {
            ITEBSCalculation calculation = null;

            try
            {
                calculation = new TEBSCalculation();
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