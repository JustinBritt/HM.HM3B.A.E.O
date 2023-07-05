namespace HM.HM3B.A.E.O.Visitors.Results.OperatingRoomDayAssignedAvailabilities
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γOuterVisitor<TKey, TValue> : IγOuterVisitor<TKey, TValue>
        where TKey : IrIndexElement
        where TValue : RedBlackTree<ItIndexElement, IγResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IFhirDateTimeComparer FhirDateTimeComparer,
            ILocationComparer locationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.FhirDateTimeComparer = FhirDateTimeComparer;

            this.RedBlackTree = this.RedBlackTreeFactory.Create<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>(
                locationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private IFhirDateTimeComparer FhirDateTimeComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = obj.Key;

            RedBlackTree<ItIndexElement, IγResultElement> value = obj.Value;

            IγInnerVisitor<ItIndexElement, IγResultElement> innerVisitor = new γInnerVisitor<ItIndexElement, IγResultElement>(
                this.NullableValueFactory,
                this.RedBlackTreeFactory,
                this.FhirDateTimeComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                rIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}