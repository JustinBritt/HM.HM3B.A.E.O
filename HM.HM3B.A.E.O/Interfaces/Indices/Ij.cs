namespace HM.HM3B.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface Ij
    {
        RedBlackTree<Organization, IjIndexElement> Value { get; }

        IjIndexElement GetElementAt(
            Organization value);
    }
}