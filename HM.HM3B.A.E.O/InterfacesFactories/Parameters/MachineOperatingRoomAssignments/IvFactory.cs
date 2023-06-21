namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.MachineOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MachineOperatingRoomAssignments;

    public interface IvFactory
    {
        Iv Create(
            RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvParameterElement>> value);
    }
}