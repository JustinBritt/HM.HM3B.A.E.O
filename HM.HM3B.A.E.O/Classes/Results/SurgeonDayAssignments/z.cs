namespace HM.HM3B.A.E.O.Classes.Results.SurgeonDayAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class z : Iz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public z(
            ImmutableList<IzResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IzResultElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.tIndexElement == tIndexElement)
                .Select(x => x.Value ? 1 : 0)
                .SingleOrDefault();
        }

        public ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.sIndexElement.Value,
                    i.tIndexElement.Value,
                    nullableValueFactory.Create<bool>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}