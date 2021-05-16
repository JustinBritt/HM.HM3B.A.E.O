namespace HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms;

    public interface ISurgeonNumberAssignedOperatingRoomsFactory
    {
        ISurgeonNumberAssignedOperatingRooms Create(
            ImmutableList<ISurgeonNumberAssignedOperatingRoomsResultElement> value);
    }
}