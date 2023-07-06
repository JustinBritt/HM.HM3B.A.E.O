namespace HM.HM3B.A.E.O.Classes.Results.SurgeonDayAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class z : Iz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public z(
            RedBlackTree<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value[sIndexElement][tIndexElement].Value ? 1 : 0;
        }

        public ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value.Values.SelectMany(w => w.Values).ToList()
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