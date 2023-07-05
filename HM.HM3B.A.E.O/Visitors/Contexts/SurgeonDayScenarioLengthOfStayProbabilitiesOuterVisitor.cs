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
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonDayScenarioLengthOfStayProbabilitiesOuterVisitor<TKey, TValue> : ISurgeonDayScenarioLengthOfStayProbabilitiesOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayScenarioLengthOfStayProbabilitiesOuterVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            IpParameterElementFactory pParameterElementFactory,
            Il l,
            Is s,
            IΛ Λ)
        {
            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.pParameterElementFactory = pParameterElementFactory;

            this.l = l;

            this.s = s;

            this.Λ = Λ;

            this.RedBlackTree = this.RedBlackTreeFactory.Create<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IpParameterElement>>>();
        }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private IpParameterElementFactory pParameterElementFactory { get; }

        private Il l { get; }
        
        private Is s { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IpParameterElement>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> value = obj.Value;

            ISurgeonDayScenarioLengthOfStayProbabilitiesFirstInnerVisitor<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> innerVisitor = new SurgeonDayScenarioLengthOfStayProbabilitiesFirstInnerVisitor<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                this.RedBlackTreeFactory,
                this.pParameterElementFactory,
                sIndexElement,
                this.l,
                this.Λ);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}