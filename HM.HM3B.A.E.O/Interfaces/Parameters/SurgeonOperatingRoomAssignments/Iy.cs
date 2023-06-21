namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;

    public interface Iy
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyParameterElement>> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement);
    }
}