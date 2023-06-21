namespace HM.HM3B.A.E.O.Visitors.Results.SurgeonOperatingRoomAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomAssignments;

    internal sealed class yInnerVisitor<TKey, TValue> : IyInnerVisitor<TKey, TValue>
        where TKey : IrIndexElement
        where TValue : IyResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yInnerVisitor(
            INullableValueFactory nullableValueFactory,
            ILocationComparer locationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTree = new RedBlackTree<Location, INullableValue<bool>>(
                locationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Location, INullableValue<bool>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Key.Value,
                this.NullableValueFactory.Create<bool>(
                    obj.Value.Value));
        }
    }
}