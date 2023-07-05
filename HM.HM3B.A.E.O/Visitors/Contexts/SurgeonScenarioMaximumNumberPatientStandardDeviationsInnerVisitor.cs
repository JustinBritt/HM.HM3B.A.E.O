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

    internal sealed class SurgeonScenarioMaximumNumberPatientStandardDeviationsInnerVisitor<TKey, TValue> : ISurgeonScenarioMaximumNumberPatientStandardDeviationsInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioMaximumNumberPatientStandardDeviationsInnerVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            IσParameterElementFactory σParameterElementFactory,
            IsIndexElement sIndexElement,
            IΛ Λ)
        {
            this.σParameterElementFactory = σParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.Λ = Λ;

            this.RedBlackTree = redBlackTreeFactory.Create<IΛIndexElement, IσParameterElement>();
        }

        private IσParameterElementFactory σParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IΛIndexElement, IσParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IΛIndexElement ΛIndexElement = this.Λ.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                ΛIndexElement,
                this.σParameterElementFactory.Create(
                    this.sIndexElement,
                    ΛIndexElement,
                    obj.Value));
        }
    }
}