namespace HM.HM3B.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface Ir
    {
        RedBlackTree<Location, IrIndexElement> Value { get; }

        IrIndexElement GetElementAt(
            Location value);
    }
}