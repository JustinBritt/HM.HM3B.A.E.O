namespace HM.HM3B.A.E.O.Factories.Calculations.SurgicalSpecialtyNumberAssignedWeekdays
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class SurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory : ISurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory()
        {
        }

        public ISurgicalSpecialtyNumberAssignedWeekdaysCalculation Create()
        {
            ISurgicalSpecialtyNumberAssignedWeekdaysCalculation calculation = null;

            try
            {
                calculation = new SurgicalSpecialtyNumberAssignedWeekdaysCalculation();
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