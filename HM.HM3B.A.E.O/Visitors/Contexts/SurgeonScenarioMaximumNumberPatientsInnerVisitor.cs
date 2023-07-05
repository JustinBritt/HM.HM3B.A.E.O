namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue> : ISurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioMaximumNumberPatientsInnerVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            InParameterElementFactory nParameterElementFactory,
            IsIndexElement sIndexElement,
            IΛ Λ)
        {
            this.nParameterElementFactory = nParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.Λ = Λ;

            this.RedBlackTree = redBlackTreeFactory.Create<IΛIndexElement, InParameterElement>();
        }

        private InParameterElementFactory nParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IΛIndexElement, InParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IΛIndexElement ΛIndexElement = this.Λ.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                ΛIndexElement,
                this.nParameterElementFactory.Create(
                    this.sIndexElement,
                    ΛIndexElement,
                    obj.Value));
        }
    }
}