namespace HM.HM3B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedWeekdays
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgicalSpecialtyNumberAssignedWeekdays
    {
        ImmutableList<ISurgicalSpecialtyNumberAssignedWeekdaysResultElement> Value { get; }

        RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}