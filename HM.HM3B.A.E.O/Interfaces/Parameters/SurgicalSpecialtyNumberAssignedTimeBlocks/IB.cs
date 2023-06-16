namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;

    public interface IB
    {
        RedBlackTree<IjIndexElement, IBParameterElement> Value { get; }

        int GetElementAtAsint(
            IjIndexElement jIndexElement);
    }
}