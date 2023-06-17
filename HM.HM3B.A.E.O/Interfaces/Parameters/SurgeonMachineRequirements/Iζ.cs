namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;

    public interface Iζ
    {
        RedBlackTree<IsIndexElement, RedBlackTree<ImIndexElement, IζParameterElement>> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ImIndexElement mIndexElement);
    }
}