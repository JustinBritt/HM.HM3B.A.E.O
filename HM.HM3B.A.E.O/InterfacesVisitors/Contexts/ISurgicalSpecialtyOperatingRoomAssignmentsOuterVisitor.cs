﻿namespace HM.HM3B.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;

    public interface ISurgicalSpecialtyOperatingRoomAssignmentsOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Organization
        where TValue : RedBlackTree<Location, INullableValue<bool>>
    {
        RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwParameterElement>> RedBlackTree { get; }
    }
}