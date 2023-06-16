namespace HM.HM3B.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface It
    {
        RedBlackTree<FhirDateTime, ItIndexElement> Value { get; }

        ItIndexElement GetElementAt(
            int value);

        ItIndexElement GetElementAt(
            FhirDateTime value);

        ImmutableList<ItIndexElement> GetNthElementsAt(
            int startKey,
            int endKey,
            int N);

        int GetT();
    }
}