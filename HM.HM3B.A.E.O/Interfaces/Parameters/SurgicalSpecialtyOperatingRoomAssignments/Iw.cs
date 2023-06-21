namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;

    public interface Iw
    {
        RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwParameterElement>> Value { get; }

        int GetElementAtAsint(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement);
    }
}