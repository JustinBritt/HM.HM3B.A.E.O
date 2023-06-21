namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgicalSpecialtyOperatingRoomAssignmentsInnerVisitor<TKey, TValue> : ISurgicalSpecialtyOperatingRoomAssignmentsInnerVisitor<TKey, TValue>
        where TKey : Location
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyOperatingRoomAssignmentsInnerVisitor(
            IwParameterElementFactory wParameterElementFactory,
            IjIndexElement jIndexElement,
            Ir r)
        {
            this.wParameterElementFactory = wParameterElementFactory;

            this.jIndexElement = jIndexElement;

            this.r = r;

            this.RedBlackTree = new RedBlackTree<IrIndexElement, IwParameterElement>();
        }

        private IwParameterElementFactory wParameterElementFactory { get; }

        private IjIndexElement jIndexElement { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IrIndexElement, IwParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = this.r.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                rIndexElement,
                this.wParameterElementFactory.Create(
                    this.jIndexElement,
                    rIndexElement,
                    obj.Value));
        }
    }
}