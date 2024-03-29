﻿namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonOperatingRoomAssignmentsOuterVisitor<TKey, TValue> : ISurgeonOperatingRoomAssignmentsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<Location, INullableValue<bool>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonOperatingRoomAssignmentsOuterVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            IyParameterElementFactory yParameterElementFactory,
            Ir r,
            Is s)
        {
            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.yParameterElementFactory = yParameterElementFactory;

            this.r = r;

            this.s = s;

            this.RedBlackTree = this.RedBlackTreeFactory.Create<IsIndexElement, RedBlackTree<IrIndexElement, IyParameterElement>>();
        }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private IyParameterElementFactory yParameterElementFactory { get; }

        private Ir r { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<Location, INullableValue<bool>> value = obj.Value;

            ISurgeonOperatingRoomAssignmentsInnerVisitor<Location, INullableValue<bool>> innerVisitor = new SurgeonOperatingRoomAssignmentsInnerVisitor<Location, INullableValue<bool>>(
                this.RedBlackTreeFactory,
                this.yParameterElementFactory,
                sIndexElement,
                this.r);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}