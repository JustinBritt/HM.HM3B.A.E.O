namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonOperatingRoomAssignmentsInnerVisitor<TKey, TValue> : ISurgeonOperatingRoomAssignmentsInnerVisitor<TKey, TValue>
        where TKey : Location
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonOperatingRoomAssignmentsInnerVisitor(
            IyParameterElementFactory yParameterElementFactory,
            IsIndexElement sIndexElement,
            Ir r)
        {
            this.yParameterElementFactory = yParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.r = r;

            this.RedBlackTree = new RedBlackTree<IrIndexElement, IyParameterElement>();
        }

        private IyParameterElementFactory yParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IrIndexElement, IyParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = this.r.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                rIndexElement,
                this.yParameterElementFactory.Create(
                    this.sIndexElement,
                    rIndexElement,
                    obj.Value));
        }
    }
}