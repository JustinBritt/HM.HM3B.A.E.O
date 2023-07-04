namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonDayScenarioLengthOfStayProbabilitiesFirstInnerVisitor<TKey, TValue> : ISurgeonDayScenarioLengthOfStayProbabilitiesFirstInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayScenarioLengthOfStayProbabilitiesFirstInnerVisitor(
            IpParameterElementFactory pParameterElementFactory,
            IsIndexElement sIndexElement,
            Il l,
            IΛ Λ)
        {
            this.pParameterElementFactory = pParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.l = l;

            this.Λ = Λ;

            this.RedBlackTree = new RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IpParameterElement>>();
        }

        private IpParameterElementFactory pParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private Il l { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IpParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IlIndexElement lIndexElement = this.l.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, INullableValue<decimal>> value = obj.Value;

            ISurgeonDayScenarioLengthOfStayProbabilitiesSecondInnerVisitor<INullableValue<int>, INullableValue<decimal>> innerVisitor = new SurgeonDayScenarioLengthOfStayProbabilitiesSecondInnerVisitor<INullableValue<int>, INullableValue<decimal>>(
                this.pParameterElementFactory,
                this.sIndexElement,
                lIndexElement,
                this.Λ);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                lIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}