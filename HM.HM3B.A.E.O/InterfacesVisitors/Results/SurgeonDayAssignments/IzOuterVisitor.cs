namespace HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonDayAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;

    public interface IzOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IsIndexElement
        where TValue : RedBlackTree<ItIndexElement, IzResultElement>
    {
        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> RedBlackTree { get; }
    }
}