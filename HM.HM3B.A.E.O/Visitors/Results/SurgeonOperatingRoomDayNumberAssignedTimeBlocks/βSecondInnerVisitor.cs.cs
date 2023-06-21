namespace HM.HM3B.A.E.O.Visitors.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class βSecondInnerVisitor<TKey, TValue> : IβSecondInnerVisitor<TKey, TValue>
        where TKey : IdIndexElement
        where TValue : IβResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βSecondInnerVisitor(
            INullableValueFactory nullableValueFactory,
            INullableValueintComparer nullableValueintComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTree = new RedBlackTree<INullableValue<int>, INullableValue<int>>(
                nullableValueintComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<INullableValue<int>, INullableValue<int>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Key.Value,
                this.NullableValueFactory.Create<int>(
                    obj.Value.Value));
        }
    }
}