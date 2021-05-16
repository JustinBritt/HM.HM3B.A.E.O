namespace HM.HM3B.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedWeekdays
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class SurgicalSpecialtyNumberAssignedWeekdaysCalculation : ISurgicalSpecialtyNumberAssignedWeekdaysCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedWeekdaysCalculation()
        {
        }

        public ISurgicalSpecialtyNumberAssignedWeekdays Calculate(
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory surgicalSpecialtyNumberAssignedWeekdaysResultElementFactory,
            ISurgicalSpecialtyNumberAssignedWeekdaysFactory surgicalSpecialtyNumberAssignedWeekdaysFactory,
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation surgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation,
            IΔ Δ,
            Ix x)
        {
            return surgicalSpecialtyNumberAssignedWeekdaysFactory.Create(
                Δ.Value
                .Select(i => surgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation.Calculate(
                    surgicalSpecialtyNumberAssignedWeekdaysResultElementFactory,
                    i,
                    x))
                .ToImmutableList());
        }
    }
}