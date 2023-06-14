namespace HM.HM3B.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;

    public interface IDayAvailabilitiesVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : FhirDateTime
        where TValue : INullableValue<bool>
    {
        RedBlackTree<ItIndexElement, IψParameterElement> RedBlackTree { get; }
    }
}