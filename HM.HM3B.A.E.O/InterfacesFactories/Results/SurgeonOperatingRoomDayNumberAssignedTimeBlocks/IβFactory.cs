namespace HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    public interface IβFactory
    {
        Iβ Create(
            ImmutableList<IβResultElement> value);
    }
}