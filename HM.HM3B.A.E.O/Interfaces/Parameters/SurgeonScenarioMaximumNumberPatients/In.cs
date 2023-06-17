namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    public interface In
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, InParameterElement>> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement);
    }
}