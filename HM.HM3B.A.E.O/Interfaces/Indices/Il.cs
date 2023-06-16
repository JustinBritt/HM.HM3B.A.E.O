namespace HM.HM3B.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface Il
    {
        RedBlackTree<INullableValue<int>, IlIndexElement> Value { get; }

        IlIndexElement GetElementAt(
            int day);

        IlIndexElement GetElementAt(
            INullableValue<int> day);
    }
}