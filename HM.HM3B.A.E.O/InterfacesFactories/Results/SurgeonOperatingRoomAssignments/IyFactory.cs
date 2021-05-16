namespace HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;

    public interface IyFactory
    {
        Iy Create(
            ImmutableList<IyResultElement> value);
    }
}