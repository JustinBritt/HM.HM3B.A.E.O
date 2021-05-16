namespace HM.HM3B.A.E.O.Interfaces.Results.SurgeonNumberAssignedWeekdays
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    
    public interface ISurgeonNumberAssignedWeekdays
    {
        ImmutableList<ISurgeonNumberAssignedWeekdaysResultElement> Value { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}