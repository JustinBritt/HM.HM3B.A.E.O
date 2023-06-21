namespace HM.HM3B.A.E.O.Interfaces.Parameters.MachineOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;

    public interface Iv
    {
        RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvParameterElement>> Value { get; }

        int GetElementAtAsint(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement);
    }
}