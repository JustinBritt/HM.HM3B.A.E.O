namespace HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement
    {
        IjIndexElement jIndexElement { get; }

        int Value { get; }
    }
}