namespace HM.HM3B.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedWeekdays
{
    using System;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class SurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation : ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation()
        {
        }

        public ISurgicalSpecialtyNumberAssignedWeekdaysResultElement Calculate(
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory surgicalSpecialtyNumberAssignedWeekdaysResultElementFactory,
            IΔParameterElement ΔParameterElement,
            Ix x)
        {
            return surgicalSpecialtyNumberAssignedWeekdaysResultElementFactory.Create(
                ΔParameterElement.jIndexElement,
                ΔParameterElement.Value.SelectMany(a => x.Value[a].Values.SelectMany(w => w.Values).Where(w => w.Value)).Select(w => w.tIndexElement.Value.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.DayOfWeek).Distinct().Count());
        }
    }
}