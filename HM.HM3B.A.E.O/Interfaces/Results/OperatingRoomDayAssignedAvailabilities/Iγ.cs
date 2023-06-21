namespace HM.HM3B.A.E.O.Interfaces.Results.OperatingRoomDayAssignedAvailabilities
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Iγ
    {
        RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>> Value { get; }

        ImmutableList<Tuple<Location, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}