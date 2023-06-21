namespace HM.HM3B.A.E.O.InterfacesVisitors.Results.OperatingRoomDayAssignedAvailabilities
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;

    public interface IγInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : ItIndexElement
        where TValue : IγResultElement
    {
        RedBlackTree<FhirDateTime, INullableValue<bool>> RedBlackTree { get; }
    }
}