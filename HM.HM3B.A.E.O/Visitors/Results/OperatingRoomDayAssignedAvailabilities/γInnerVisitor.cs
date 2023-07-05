namespace HM.HM3B.A.E.O.Visitors.Results.OperatingRoomDayAssignedAvailabilities
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γInnerVisitor<TKey, TValue> : IγInnerVisitor<TKey, TValue>
        where TKey : ItIndexElement
        where TValue : IγResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γInnerVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IFhirDateTimeComparer FhirDateTimeComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTree = redBlackTreeFactory.Create<FhirDateTime, INullableValue<bool>>(
                FhirDateTimeComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<FhirDateTime, INullableValue<bool>> RedBlackTree { get; }

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