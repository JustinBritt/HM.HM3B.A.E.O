namespace HM.HM3B.A.E.O.Factories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.Contexts;
    using HM.HM3B.A.E.O.Interfaces.Contexts;
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;

    internal sealed class HM3BInputContextFactory : IHM3BInputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BInputContextFactory()
        {
        }

        public IHM3BInputContext Create(
            ImmutableList<INullableValue<int>> weekdays,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> surgicalSpecialties,
            ImmutableList<INullableValue<int>> lengthOfStayDays,
            Bundle machines,
            Bundle operatingRooms,
            Bundle surgeons,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            ImmutableList<INullableValue<int>> scenarios,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgicalSpecialtyNumberAssignedTimeBlocks,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonNumberAssignedTimeBlocks,
            Duration timeBlockLength,
            ImmutableList<Tuple<Organization, INullableValue<int>, Duration>> surgeonScenarioWeightedAverageSurgicalDurations,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonLengthOfStayMaximums,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> surgeonDayScenarioLengthOfStayProbabilities,
            ImmutableList<Tuple<Device, Location, INullableValue<bool>>> machineOperatingRoomAssignments,
            INullableValue<int> numberDaysPerWeek,
            ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> surgicalSpecialtyOperatingRoomAssignments,
            ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> surgeonOperatingRoomAssignments,
            ImmutableList<Tuple<Organization, Device, INullableValue<bool>>> surgeonMachineRequirements,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientMeans,
            ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<decimal>>> scenarioProbabilities,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientStandardDeviations,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> dayAvailabilities,
            INullableValue<int> maximumNumberRecoveryWardBeds)
        {
            IHM3BInputContext context = null;

            try
            {
                context = new HM3BInputContext(
                    weekdays,
                    surgicalSpecialties,
                    lengthOfStayDays,
                    machines,
                    operatingRooms,
                    surgeons,
                    planningHorizon,
                    scenarios,
                    surgicalSpecialtyNumberAssignedTimeBlocks,
                    surgeonNumberAssignedTimeBlocks,
                    timeBlockLength,
                    surgeonScenarioWeightedAverageSurgicalDurations,
                    surgeonLengthOfStayMaximums,
                    surgeonScenarioMaximumNumberPatients,
                    surgeonDayScenarioLengthOfStayProbabilities,
                    machineOperatingRoomAssignments,
                    numberDaysPerWeek,
                    surgicalSpecialtyOperatingRoomAssignments,
                    surgeonOperatingRoomAssignments,
                    surgeonMachineRequirements,
                    surgeonScenarioMaximumNumberPatientMeans,
                    scenarioProbabilities,
                    surgeonScenarioMaximumNumberPatientStandardDeviations,
                    dayAvailabilities,
                    maximumNumberRecoveryWardBeds);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}