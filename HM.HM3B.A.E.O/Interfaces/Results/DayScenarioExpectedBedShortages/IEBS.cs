namespace HM.HM3B.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IEBS
    {
        ImmutableList<IEBSResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement);

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            It t,
            IΛ Λ);
    }
}