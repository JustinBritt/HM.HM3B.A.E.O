namespace HM.HM3B.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    
    public interface Im
    {
        RedBlackTree<Device, ImIndexElement> Value { get; }

        ImIndexElement GetElementAt(
            Device value);

        int GetM();
    }
}