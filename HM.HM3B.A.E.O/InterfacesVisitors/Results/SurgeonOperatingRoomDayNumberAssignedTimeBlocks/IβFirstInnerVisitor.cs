namespace HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    public interface IβFirstInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IrIndexElement
        where TValue : RedBlackTree<IdIndexElement, IβResultElement>
    {
        RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>> RedBlackTree { get; }
    }
}