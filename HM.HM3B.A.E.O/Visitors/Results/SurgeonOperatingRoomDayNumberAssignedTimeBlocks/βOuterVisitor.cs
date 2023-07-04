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

    internal sealed class βOuterVisitor<TKey, TValue> : IβOuterVisitor<TKey, TValue>
        where TKey : IsIndexElement
        where TValue : RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βOuterVisitor(
            INullableValueFactory nullableValueFactory,
            ILocationComparer locationComparer,
            INullableValueintComparer nullableValueintComparer,
            IOrganizationComparer organizationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.LocationComparer = locationComparer;

            this.NullableValueintComparer = nullableValueintComparer;

            this.RedBlackTree = new RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>>>(
                organizationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private INullableValueintComparer NullableValueintComparer { get; }

        private ILocationComparer LocationComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = obj.Key;

            RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>> value = obj.Value;

            IβFirstInnerVisitor<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>> innerVisitor = new βFirstInnerVisitor<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>>(
                this.NullableValueFactory,
                this.LocationComparer,
                this.NullableValueintComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}