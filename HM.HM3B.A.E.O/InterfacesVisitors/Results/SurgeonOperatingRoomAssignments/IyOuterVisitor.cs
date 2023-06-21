namespace HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;

    public interface IyOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IsIndexElement
        where TValue : RedBlackTree<IrIndexElement, IyResultElement>
    {
        RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> RedBlackTree { get; }
    }
}