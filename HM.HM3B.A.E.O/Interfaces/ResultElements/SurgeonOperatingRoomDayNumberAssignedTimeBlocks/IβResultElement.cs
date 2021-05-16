namespace HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IβResultElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        IdIndexElement dIndexElement { get; }

        int Value { get; }
    }
}