namespace HM.HM3B.A.E.O.Visitors.Results.SurgeonOperatingRoomAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomAssignments;
 
    internal sealed class yOuterVisitor<TKey, TValue> : IyOuterVisitor<TKey, TValue>
        where TKey : IsIndexElement
        where TValue : RedBlackTree<IrIndexElement, IyResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yOuterVisitor(
            INullableValueFactory nullableValueFactory,
            ILocationComparer locationComparer,
            IOrganizationComparer organizationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.LocationComparer = locationComparer;

            this.RedBlackTree = new RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>>(
                organizationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private ILocationComparer LocationComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = obj.Key;

            RedBlackTree<IrIndexElement, IyResultElement> value = obj.Value;

            var innerVisitor = new yInnerVisitor<IrIndexElement, IyResultElement>(
                this.NullableValueFactory,
                this.LocationComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}