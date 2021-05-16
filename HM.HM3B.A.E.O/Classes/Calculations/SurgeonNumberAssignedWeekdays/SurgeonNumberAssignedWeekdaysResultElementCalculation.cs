namespace HM.HM3B.A.E.O.Classes.Calculations.SurgeonNumberAssignedWeekdays
{
    using System;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;

    internal sealed class SurgeonNumberAssignedWeekdaysResultElementCalculation : ISurgeonNumberAssignedWeekdaysResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedWeekdaysResultElementCalculation()
        {
        }

        public ISurgeonNumberAssignedWeekdaysResultElement Calculate(
            ISurgeonNumberAssignedWeekdaysResultElementFactory surgeonNumberAssignedWeekdaysResultElementFactory,
            IsIndexElement sIndexElement,
            Ix x)
        {
            return surgeonNumberAssignedWeekdaysResultElementFactory.Create(
                sIndexElement,
                x.Value.Where(i => i.sIndexElement == sIndexElement && i.Value).Select(i => i.tIndexElement.Value.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.DayOfWeek).Distinct().Count());
        }
    }
}