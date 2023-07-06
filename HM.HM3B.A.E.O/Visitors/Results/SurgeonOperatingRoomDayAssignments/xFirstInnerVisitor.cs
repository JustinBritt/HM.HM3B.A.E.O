namespace HM.HM3B.A.E.O.Visitors.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Visitors.Results.SurgeonOperatingRoomDayAssignments;
    
    internal sealed class xFirstInnerVisitor<TKey, TValue> : IxFirstInnerVisitor<TKey, TValue>
        where TKey : IrIndexElement
        where TValue : RedBlackTree<ItIndexElement, IxResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xFirstInnerVisitor(
            INullableValueFactory nullableValueFactory,
            IFhirDateTimeComparer FhirDateTimeComparer,
            ILocationComparer locationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.FhirDateTimeComparer = FhirDateTimeComparer;

            this.RedBlackTree = new RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>(
                locationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IFhirDateTimeComparer FhirDateTimeComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = obj.Key;

            RedBlackTree<ItIndexElement, IxResultElement> value = obj.Value;

            IxSecondInnerVisitor<ItIndexElement, IxResultElement> innerVisitor = new xSecondInnerVisitor<ItIndexElement, IxResultElement>(
                this.NullableValueFactory,
                this.FhirDateTimeComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                rIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}