﻿namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class MachineOperatingRoomAssignmentsOuterVisitor<TKey, TValue> : IMachineOperatingRoomAssignmentsOuterVisitor<TKey, TValue>
        where TKey : Device
        where TValue : RedBlackTree<Location, INullableValue<bool>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MachineOperatingRoomAssignmentsOuterVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            IvParameterElementFactory vParameterElementFactory,
            Im m,
            Ir r)
        {
            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.vParameterElementFactory = vParameterElementFactory;

            this.m = m;

            this.r = r;

            this.RedBlackTree = this.RedBlackTreeFactory.Create<ImIndexElement, RedBlackTree<IrIndexElement, IvParameterElement>>();
        }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private IvParameterElementFactory vParameterElementFactory { get; }

        private Im m { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            ImIndexElement mIndexElement = this.m.GetElementAt(
                obj.Key);

            RedBlackTree<Location, INullableValue<bool>> value = obj.Value;

            IMachineOperatingRoomAssignmentsInnerVisitor<Location, INullableValue<bool>> innerVisitor = new MachineOperatingRoomAssignmentsInnerVisitor<Location, INullableValue<bool>>(
                this.RedBlackTreeFactory,
                this.vParameterElementFactory,
                mIndexElement,
                this.r);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                mIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}