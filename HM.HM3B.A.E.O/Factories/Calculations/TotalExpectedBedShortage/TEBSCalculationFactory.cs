namespace HM.HM3B.A.E.O.Factories.Calculations.TotalExpectedBedShortage
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.TotalExpectedBedShortage;
    using HM.HM3B.A.E.O.Interfaces.Calculations.TotalExpectedBedShortage;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.TotalExpectedBedShortage;

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
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}