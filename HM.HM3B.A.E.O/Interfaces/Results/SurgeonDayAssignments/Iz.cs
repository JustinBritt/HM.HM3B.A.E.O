namespace HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Iz
    {
        RedBlackTree<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement);

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}