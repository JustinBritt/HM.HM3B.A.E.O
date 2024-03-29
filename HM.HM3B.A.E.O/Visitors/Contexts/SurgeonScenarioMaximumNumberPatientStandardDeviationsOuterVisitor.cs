﻿namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;
    
    internal sealed class SurgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor<TKey, TValue> : ISurgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            IσParameterElementFactory σParameterElementFactory,
            Is s,
            IΛ Λ)
        {
            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.σParameterElementFactory = σParameterElementFactory;

            this.s = s;

            this.Λ = Λ;

            this.RedBlackTree = this.RedBlackTreeFactory.Create<IsIndexElement, RedBlackTree<IΛIndexElement, IσParameterElement>>();
        }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private IσParameterElementFactory σParameterElementFactory { get; }

        private Is s { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, IσParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, INullableValue<decimal>> value = obj.Value;

            ISurgeonScenarioMaximumNumberPatientStandardDeviationsInnerVisitor<INullableValue<int>, INullableValue<decimal>> innerVisitor = new SurgeonScenarioMaximumNumberPatientStandardDeviationsInnerVisitor<INullableValue<int>, INullableValue<decimal>>(
                this.RedBlackTreeFactory,
                this.σParameterElementFactory,
                sIndexElement,
                this.Λ);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}