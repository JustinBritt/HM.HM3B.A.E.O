namespace HM.HM3B.A.E.O.InterfacesFactories.Results.OperatingRoomDayAssignedAvailabilities
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Results.OperatingRoomDayAssignedAvailabilities;

    public interface IγFactory
    {
        Iγ Create(
            RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>> value);
    }
}