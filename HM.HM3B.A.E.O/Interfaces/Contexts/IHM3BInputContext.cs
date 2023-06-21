namespace HM.HM3B.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IHM3BInputContext
    {
        ImmutableSortedSet<INullableValue<int>> Weekdays { get; }

        RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        Bundle Machines { get; }

        Bundle OperatingRooms { get; }

        Bundle Surgeons { get; }

        RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        ImmutableSortedSet<INullableValue<int>> Scenarios { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedTimeBlocks { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedTimeBlocks { get; }

        Duration TimeBlockLength { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonLengthOfStayMaximums { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        RedBlackTree<Device, RedBlackTree<Location, INullableValue<bool>>> MachineOperatingRoomAssignments { get; }

        INullableValue<int> NumberDaysPerWeek { get; }

        ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> SurgicalSpecialtyOperatingRoomAssignments { get; }

        ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<Device, INullableValue<bool>>> SurgeonMachineRequirements { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientMeans { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioProbabilities { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientStandardDeviations { get; }

        RedBlackTree<FhirDateTime, INullableValue<bool>> DayAvailabilities { get; }

        INullableValue<int> MaximumNumberRecoveryWardBeds { get; }
    }
}