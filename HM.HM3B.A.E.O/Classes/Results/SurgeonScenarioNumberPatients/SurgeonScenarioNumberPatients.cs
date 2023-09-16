namespace HM.HM3B.A.E.O.Classes.Results.SurgeonScenarioNumberPatients
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonScenarioNumberPatients : ISurgeonScenarioNumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatients(
            ImmutableList<ISurgeonScenarioNumberPatientsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonScenarioNumberPatientsResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Is s,
            IΛ Λ)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.sIndexElement.Value,
                    (INullableValue<int>)i.ΛIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}