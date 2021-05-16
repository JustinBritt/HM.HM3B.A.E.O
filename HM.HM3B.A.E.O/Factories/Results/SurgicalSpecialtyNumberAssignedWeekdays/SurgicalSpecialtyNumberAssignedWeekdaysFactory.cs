namespace HM.HM3B.A.E.O.Factories.Results.SurgicalSpecialtyNumberAssignedWeekdays
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class SurgicalSpecialtyNumberAssignedWeekdaysFactory : ISurgicalSpecialtyNumberAssignedWeekdaysFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedWeekdaysFactory()
        {
        }

        public ISurgicalSpecialtyNumberAssignedWeekdays Create(
            ImmutableList<ISurgicalSpecialtyNumberAssignedWeekdaysResultElement> value)
        {
            ISurgicalSpecialtyNumberAssignedWeekdays result = null;

            try
            {
                result = new SurgicalSpecialtyNumberAssignedWeekdays(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}