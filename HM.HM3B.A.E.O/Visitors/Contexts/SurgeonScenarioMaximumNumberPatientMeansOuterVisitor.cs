namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonScenarioMaximumNumberPatientMeansOuterVisitor<TKey, TValue> : ISurgeonScenarioMaximumNumberPatientMeansOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioMaximumNumberPatientMeansOuterVisitor(
            IμParameterElementFactory μParameterElementFactory,
            Is s,
            IΛ Λ)
        {
            this.μParameterElementFactory = μParameterElementFactory;

            this.s = s;

            this.Λ = Λ;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, IμParameterElement>>();
        }

        private IμParameterElementFactory μParameterElementFactory { get; }

        private Is s { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, IμParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, INullableValue<decimal>> value = obj.Value;

            ISurgeonScenarioMaximumNumberPatientMeansInnerVisitor<INullableValue<int>, INullableValue<decimal>> innerVisitor = new SurgeonScenarioMaximumNumberPatientMeansInnerVisitor<INullableValue<int>, INullableValue<decimal>>(
                this.μParameterElementFactory,
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