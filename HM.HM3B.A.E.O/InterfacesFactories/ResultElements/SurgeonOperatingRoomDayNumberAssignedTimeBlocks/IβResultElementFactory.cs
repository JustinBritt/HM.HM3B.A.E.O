namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    public interface IβResultElementFactory
    {
        IβResultElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            int value);
    }
}