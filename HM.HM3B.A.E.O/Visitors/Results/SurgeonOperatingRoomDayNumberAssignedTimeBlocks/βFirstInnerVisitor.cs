namespace HM.HM3B.A.E.O.Visitors.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class βFirstInnerVisitor<TKey, TValue> : IβFirstInnerVisitor<TKey, TValue>
        where TKey : IrIndexElement
        where TValue : RedBlackTree<IdIndexElement, IβResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βFirstInnerVisitor(
            INullableValueFactory nullableValueFactory,
            ILocationComparer locationComparer,
            INullableValueintComparer nullableValueintComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.NullableValueintComparer = nullableValueintComparer;

            this.RedBlackTree = new RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>>(
                locationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private INullableValueintComparer NullableValueintComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = obj.Key;

            RedBlackTree<IdIndexElement, IβResultElement> value = obj.Value;

            var innerVisitor = new βSecondInnerVisitor<IdIndexElement, IβResultElement>(
                this.NullableValueFactory,
                this.NullableValueintComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                rIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}