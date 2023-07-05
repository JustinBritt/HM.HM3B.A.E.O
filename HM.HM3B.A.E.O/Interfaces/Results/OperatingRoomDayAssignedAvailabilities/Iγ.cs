namespace HM.HM3B.A.E.O.Interfaces.Results.OperatingRoomDayAssignedAvailabilities
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Comparers;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;

    public interface Iγ
    {
        RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>> Value { get; }

        RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            IFhirDateTimeComparerFactory FhirDateTimeComparerFactory,
            ILocationComparerFactory locationComparerFactory,
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory);
    }
}