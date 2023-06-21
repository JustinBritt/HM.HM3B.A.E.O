namespace HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Iy
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> Value { get; }

        ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}