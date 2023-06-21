namespace HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    public interface IβFactory
    {
        Iβ Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>>> value);
    }
}