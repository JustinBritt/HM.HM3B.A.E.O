namespace HM.HM3B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgicalSpecialtyNumberAssignedOperatingRooms
    {
        ImmutableList<ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement> Value { get; }

        RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}