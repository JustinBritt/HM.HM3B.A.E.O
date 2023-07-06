namespace HM.HM3B.A.E.O.Classes.Results.SurgeonOperatingRoomDayAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value[sIndexElement][rIndexElement][tIndexElement].Value ? 1 : 0;
        }

        public ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            var xList = this.Value.Values.SelectMany(w => w.Values).SelectMany(w => w.Values).ToList();

            return xList
                .Select(
                i => Tuple.Create(
                    i.sIndexElement.Value,
                    i.rIndexElement.Value,
                    i.tIndexElement.Value,
                    nullableValueFactory.Create<bool>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}