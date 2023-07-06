namespace HM.HM3B.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IHM3BOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioExpectedBedShortages { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationExpectedValues { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<int>>> ScenarioNumberPatients { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioTotalTimes { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioUnderutilizations { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioUnutilizedTimes { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioUtilizedTimes { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgeonNumberAssignedOperatingRooms { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgeonNumberAssignedWeekdays { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioNumberPatients { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedOperatingRooms { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedWeekdays { get; }

        INullableValue<decimal> TotalExpectedBedShortage { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioTotalExpectedBedShortages { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationVariances { get; }

        RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> SurgeonOperatingRoomDayAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> SurgeonDayAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>>> SurgeonOperatingRoomDayNumberAssignedTimeBlocks { get; }

        RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> OperatingRoomDayAssignedAvailabilities { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> SurgeonDayScenarioCumulativeNumberPatients { get; }
    }
}