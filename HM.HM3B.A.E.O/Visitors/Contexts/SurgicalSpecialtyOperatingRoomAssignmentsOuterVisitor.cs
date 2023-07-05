namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgicalSpecialtyOperatingRoomAssignmentsOuterVisitor<TKey, TValue> : ISurgicalSpecialtyOperatingRoomAssignmentsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<Location, INullableValue<bool>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyOperatingRoomAssignmentsOuterVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            IwParameterElementFactory wParameterElementFactory,
            Ij j,
            Ir r)
        {
            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.wParameterElementFactory = wParameterElementFactory;

            this.j = j;

            this.r = r;

            this.RedBlackTree = this.RedBlackTreeFactory.Create<IjIndexElement, RedBlackTree<IrIndexElement, IwParameterElement>>();
        }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private IwParameterElementFactory wParameterElementFactory { get; }

        private Ij j { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IjIndexElement jIndexElement = this.j.GetElementAt(
                obj.Key);

            RedBlackTree<Location, INullableValue<bool>> value = obj.Value;

            ISurgicalSpecialtyOperatingRoomAssignmentsInnerVisitor<Location, INullableValue<bool>> innerVisitor = new SurgicalSpecialtyOperatingRoomAssignmentsInnerVisitor<Location, INullableValue<bool>>(
                this.RedBlackTreeFactory,
                this.wParameterElementFactory,
                jIndexElement,
                this.r);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                jIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}