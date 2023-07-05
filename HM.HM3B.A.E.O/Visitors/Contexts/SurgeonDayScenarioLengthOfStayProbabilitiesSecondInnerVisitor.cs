namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonDayScenarioLengthOfStayProbabilitiesSecondInnerVisitor<TKey, TValue> : ISurgeonDayScenarioLengthOfStayProbabilitiesSecondInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayScenarioLengthOfStayProbabilitiesSecondInnerVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            IpParameterElementFactory pParameterElementFactory,
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛ Λ)
        {
            this.pParameterElementFactory = pParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.lIndexElement = lIndexElement;

            this.Λ = Λ;

            this.RedBlackTree = redBlackTreeFactory.Create<IΛIndexElement, IpParameterElement>();
        }

        private IpParameterElementFactory pParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private IlIndexElement lIndexElement { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IΛIndexElement, IpParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IΛIndexElement ΛIndexElement = this.Λ.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                ΛIndexElement,
                this.pParameterElementFactory.Create(
                    this.sIndexElement,
                    this.lIndexElement,
                    ΛIndexElement,
                    obj.Value));
        }
    }
}