namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class ScenarioProbabilitiesVisitor<TKey, TValue> : IScenarioProbabilitiesVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioProbabilitiesVisitor(
            IΡParameterElementFactory ΡParameterElementFactory,
            IΛ Λ)
        {
            this.ΡParameterElementFactory = ΡParameterElementFactory;

            this.Λ = Λ;

            this.RedBlackTree = new RedBlackTree<IΛIndexElement, IΡParameterElement>();
        }

        private IΡParameterElementFactory ΡParameterElementFactory { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IΛIndexElement, IΡParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IΛIndexElement ΛIndexElement = this.Λ.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                ΛIndexElement,
                this.ΡParameterElementFactory.Create(
                    ΛIndexElement,
                    obj.Value));
        }
    }
}