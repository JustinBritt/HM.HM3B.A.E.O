namespace HM.HM3B.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.Contexts;

    public sealed class HM3BInputContext : IHM3BInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BInputContext(
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
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> surgeonDayScenarioLengthOfStayProbabilities,
            ImmutableList<Tuple<Device, Location, INullableValue<bool>>> machineOperatingRoomAssignments,
            INullableValue<int> numberDaysPerWeek,
            ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> surgicalSpecialtyOperatingRoomAssignments,
            ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> surgeonOperatingRoomAssignments,
            ImmutableList<Tuple<Organization, Device, INullableValue<bool>>> surgeonMachineRequirements,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientMeans,
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> scenarioProbabilities,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientStandardDeviations,
            RedBlackTree<FhirDateTime, INullableValue<bool>> dayAvailabilities,
            INullableValue<int> maximumNumberRecoveryWardBeds)
        {
            this.Weekdays = weekdays;

            this.SurgicalSpecialties = surgicalSpecialties;

            this.LengthOfStayDays = lengthOfStayDays;

            this.Machines = machines;

            this.OperatingRooms = operatingRooms;

            this.Surgeons = surgeons;

            this.PlanningHorizon = planningHorizon;

            this.Scenarios = scenarios;

            this.SurgicalSpecialtyNumberAssignedTimeBlocks = surgicalSpecialtyNumberAssignedTimeBlocks;

            this.SurgeonNumberAssignedTimeBlocks = surgeonNumberAssignedTimeBlocks;

            this.TimeBlockLength = timeBlockLength;

            this.SurgeonScenarioWeightedAverageSurgicalDurations = surgeonScenarioWeightedAverageSurgicalDurations;

            this.SurgeonLengthOfStayMaximums = surgeonLengthOfStayMaximums;

            this.SurgeonScenarioMaximumNumberPatients = surgeonScenarioMaximumNumberPatients;

            this.SurgeonDayScenarioLengthOfStayProbabilities = surgeonDayScenarioLengthOfStayProbabilities;

            if (machineOperatingRoomAssignments != null && machineOperatingRoomAssignments.Count > 0)
            {
                this.MachineOperatingRoomAssignments = machineOperatingRoomAssignments;
            }
            else
            {
                this.MachineOperatingRoomAssignments = null;
            }

            this.NumberDaysPerWeek = numberDaysPerWeek;

            if (surgicalSpecialtyOperatingRoomAssignments != null && surgicalSpecialtyOperatingRoomAssignments.Count > 0)
            {
                this.SurgicalSpecialtyOperatingRoomAssignments = surgicalSpecialtyOperatingRoomAssignments;
            }
            else
            {
                this.SurgicalSpecialtyOperatingRoomAssignments = null;
            }

            if (surgeonOperatingRoomAssignments != null && surgeonOperatingRoomAssignments.Count > 0)
            {
                this.SurgeonOperatingRoomAssignments = surgeonOperatingRoomAssignments;
            }
            else
            {
                this.SurgeonOperatingRoomAssignments = null;
            }

            this.SurgeonMachineRequirements = surgeonMachineRequirements;

            this.SurgeonScenarioMaximumNumberPatientMeans = surgeonScenarioMaximumNumberPatientMeans;

            this.ScenarioProbabilities = scenarioProbabilities;

            this.SurgeonScenarioMaximumNumberPatientStandardDeviations = surgeonScenarioMaximumNumberPatientStandardDeviations;

            this.DayAvailabilities = dayAvailabilities;

            this.MaximumNumberRecoveryWardBeds = maximumNumberRecoveryWardBeds;
        }

        public ImmutableSortedSet<INullableValue<int>> Weekdays { get; }

        public RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        public ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        public Bundle Machines { get; }

        public Bundle OperatingRooms { get; }

        public Bundle Surgeons { get; }

        public RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        public ImmutableSortedSet<INullableValue<int>> Scenarios { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedTimeBlocks { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedTimeBlocks { get; }

        public Duration TimeBlockLength { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonLengthOfStayMaximums { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        public ImmutableList<Tuple<Device, Location, INullableValue<bool>>> MachineOperatingRoomAssignments { get; }

        public INullableValue<int> NumberDaysPerWeek { get; }

        public ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> SurgicalSpecialtyOperatingRoomAssignments { get; }

        public ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }

        public ImmutableList<Tuple<Organization, Device, INullableValue<bool>>> SurgeonMachineRequirements { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientMeans { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioProbabilities { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientStandardDeviations { get; }

        public RedBlackTree<FhirDateTime, INullableValue<bool>> DayAvailabilities { get; }

        public INullableValue<int> MaximumNumberRecoveryWardBeds { get; }
    }
}