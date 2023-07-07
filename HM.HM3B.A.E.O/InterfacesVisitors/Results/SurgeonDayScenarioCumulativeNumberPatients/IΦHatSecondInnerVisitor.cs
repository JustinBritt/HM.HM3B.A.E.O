namespace HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IΦHatSecondInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IΛIndexElement
        where TValue : IΦHatResultElement
    {
        RedBlackTree<INullableValue<int>, INullableValue<decimal>> RedBlackTree { get; }
    }
}