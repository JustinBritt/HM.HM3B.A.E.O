namespace HM.HM3B.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms
{
    using System;
    using System.Collections.Immutable;
    
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgeonNumberAssignedOperatingRooms
    {
        ImmutableList<ISurgeonNumberAssignedOperatingRoomsResultElement> Value { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}