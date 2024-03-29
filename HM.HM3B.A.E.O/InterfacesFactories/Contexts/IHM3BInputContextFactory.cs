﻿namespace HM.HM3B.A.E.O.InterfacesFactories.Contexts
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.Contexts;

    public interface IHM3BInputContextFactory
    {
        IHM3BInputContext Create(
            ImmutableSortedSet<INullableValue<int>> weekdays,
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> surgicalSpecialties,
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            Bundle machines,
            Bundle operatingRooms,
            Bundle surgeons,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> scenarios,
            RedBlackTree<Organization, INullableValue<int>> surgicalSpecialtyNumberAssignedTimeBlocks,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberAssignedTimeBlocks,
            Duration timeBlockLength,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, Duration>> surgeonScenarioWeightedAverageSurgicalDurations,
            RedBlackTree<Organization, INullableValue<int>> surgeonLengthOfStayMaximums,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> surgeonDayScenarioLengthOfStayProbabilities,
            RedBlackTree<Device, RedBlackTree<Location, INullableValue<bool>>> machineOperatingRoomAssignments,
            INullableValue<int> numberDaysPerWeek,
            RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> surgicalSpecialtyOperatingRoomAssignments,
            RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> surgeonOperatingRoomAssignments,
            RedBlackTree<Organization, RedBlackTree<Device, INullableValue<bool>>> surgeonMachineRequirements,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientMeans,
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> scenarioProbabilities,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientStandardDeviations,
            RedBlackTree<FhirDateTime, INullableValue<bool>> dayAvailabilities,
            INullableValue<int> maximumNumberRecoveryWardBeds);
    }
}