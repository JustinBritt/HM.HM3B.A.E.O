namespace HM.HM3B.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Comparers;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IEBS
    {
        decimal GetElementAtAsdecimal(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement);

        RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            IFhirDateTimeComparerFactory FhirDateTimeComparerFactory,
            INullableValueintComparerFactory nullableValueintComparerFactory,
            INullableValueFactory nullableValueFactory,
            It t,
            IΛ Λ);
    }
}