namespace HM.HM3B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedWeekdays
{
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface ISurgicalSpecialtyNumberAssignedWeekdaysCalculation
    {
        ISurgicalSpecialtyNumberAssignedWeekdays Calculate(
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory surgicalSpecialtyNumberAssignedWeekdaysResultElementFactory,
            ISurgicalSpecialtyNumberAssignedWeekdaysFactory surgicalSpecialtyNumberAssignedWeekdaysFactory,
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation surgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation,
            IΔ Δ,
            Ix x);
    }
}