namespace HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgeonScenarioNumberPatients
    {
        ImmutableList<ISurgeonScenarioNumberPatientsResultElement> Value { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}