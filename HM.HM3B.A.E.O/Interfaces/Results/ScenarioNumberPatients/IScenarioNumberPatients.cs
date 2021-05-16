namespace HM.HM3B.A.E.O.Interfaces.Results.ScenarioNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IScenarioNumberPatients
    {
        ImmutableList<IScenarioNumberPatientsResultElement> Value { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}