namespace HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;

    public interface IyInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IrIndexElement
        where TValue : IyResultElement
    {
        RedBlackTree<Location, INullableValue<bool>> RedBlackTree { get; }
    }
}