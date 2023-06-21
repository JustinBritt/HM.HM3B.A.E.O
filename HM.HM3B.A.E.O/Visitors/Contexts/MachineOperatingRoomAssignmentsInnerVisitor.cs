namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class MachineOperatingRoomAssignmentsInnerVisitor<TKey, TValue> : IMachineOperatingRoomAssignmentsInnerVisitor<TKey, TValue>
        where TKey : Location
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MachineOperatingRoomAssignmentsInnerVisitor(
            IvParameterElementFactory vParameterElementFactory,
            ImIndexElement mIndexElement,
            Ir r)
        {
            this.vParameterElementFactory = vParameterElementFactory;

            this.mIndexElement = mIndexElement;

            this.r = r;

            this.RedBlackTree = new RedBlackTree<IrIndexElement, IvParameterElement>();
        }

        private IvParameterElementFactory vParameterElementFactory { get; }

        private ImIndexElement mIndexElement { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IrIndexElement, IvParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = this.r.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                rIndexElement,
                this.vParameterElementFactory.Create(
                    this.mIndexElement,
                    rIndexElement,
                    obj.Value));
        }
    }
}