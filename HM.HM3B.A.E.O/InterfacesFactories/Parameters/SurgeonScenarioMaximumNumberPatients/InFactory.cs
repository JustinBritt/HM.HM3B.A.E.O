namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using System.Collections.Immutable;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;

    public interface InFactory
    {
        In Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, InParameterElement>> value);
    }
}