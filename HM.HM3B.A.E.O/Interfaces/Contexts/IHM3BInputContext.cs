namespace HM.HM3B.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IHM3BInputContext
    {
        ImmutableSortedSet<INullableValue<int>> Weekdays { get; }

        ImmutableList<Tuple<Organization, ImmutableList<Organization>>> SurgicalSpecialties { get; }

        ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        Bundle Machines { get; }

        Bundle OperatingRooms { get; }

        Bundle Surgeons { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> PlanningHorizon { get; }

        ImmutableList<INullableValue<int>> Scenarios { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedTimeBlocks { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonNumberAssignedTimeBlocks { get; }

        Duration TimeBlockLength { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonLengthOfStayMaximums { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        ImmutableList<Tuple<Device, Location, INullableValue<bool>>> MachineOperatingRoomAssignments { get; }

        INullableValue<int> NumberDaysPerWeek { get; }

        ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> SurgicalSpecialtyOperatingRoomAssignments { get; }

        ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }

        ImmutableList<Tuple<Organization, Device, INullableValue<bool>>> SurgeonMachineRequirements { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientMeans { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<decimal>>> ScenarioProbabilities { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientStandardDeviations { get; }

        ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> DayAvailabilities { get; }

        INullableValue<int> MaximumNumberRecoveryWardBeds { get; }
    }
}