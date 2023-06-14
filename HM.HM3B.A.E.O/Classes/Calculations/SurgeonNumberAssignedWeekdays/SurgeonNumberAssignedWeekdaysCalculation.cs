namespace HM.HM3B.A.E.O.Classes.Calculations.SurgeonNumberAssignedWeekdays
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedWeekdays;

    internal sealed class SurgeonNumberAssignedWeekdaysCalculation : ISurgeonNumberAssignedWeekdaysCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedWeekdaysCalculation()
        {
        }

        public ISurgeonNumberAssignedWeekdays Calculate(
            ISurgeonNumberAssignedWeekdaysResultElementFactory surgeonNumberAssignedWeekdaysResultElementFactory,
            ISurgeonNumberAssignedWeekdaysFactory surgeonNumberAssignedWeekdaysFactory,
            ISurgeonNumberAssignedWeekdaysResultElementCalculation surgeonNumberAssignedWeekdaysResultElementCalculation,
            Is s,
            Ix x)
        {
            return surgeonNumberAssignedWeekdaysFactory.Create(
                s.Value.Values
                .Select(w => surgeonNumberAssignedWeekdaysResultElementCalculation.Calculate(
                    surgeonNumberAssignedWeekdaysResultElementFactory,
                    w,
                    x))
                .ToImmutableList());
        }
    }
}