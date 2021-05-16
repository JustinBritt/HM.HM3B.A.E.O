namespace HM.HM3B.A.E.O.Classes.Results.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRooms : ISurgicalSpecialtyNumberAssignedOperatingRooms
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRooms(
            ImmutableList<ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.jIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}