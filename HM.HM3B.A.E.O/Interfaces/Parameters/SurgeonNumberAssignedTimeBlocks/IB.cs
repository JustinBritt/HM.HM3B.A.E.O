namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks
{
    using NGenerics.DataStructures.Trees;
 
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;

    public interface IB
    {
        RedBlackTree<IsIndexElement, IBParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}