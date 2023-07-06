namespace HM.HM3B.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation : ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation()
        {
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            IΔParameterElement ΔParameterElement,
            Ix x)
        {
            return surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory.Create(
                ΔParameterElement.jIndexElement,
                ΔParameterElement.Value.SelectMany(a => x.Value[a].Values.SelectMany(w => w.Values).Where(w => w.Value)).Select(w => w.rIndexElement).Distinct().Count());
        }
    }
}