namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class DayAvailabilitiesVisitor<TKey, TValue> : IDayAvailabilitiesVisitor<TKey, TValue>
        where TKey : FhirDateTime
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayAvailabilitiesVisitor(
            IψParameterElementFactory ψParameterElementFactory,
            It t)
        {
            this.ψParameterElementFactory = ψParameterElementFactory;

            this.t = t;

            this.RedBlackTree = new RedBlackTree<ItIndexElement, IψParameterElement>();
        }

        private IψParameterElementFactory ψParameterElementFactory { get; }

        private It t { get; }

        public bool HasCompleted => false;

        public RedBlackTree<ItIndexElement, IψParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            ItIndexElement tIndexElement = this.t.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                tIndexElement,
                this.ψParameterElementFactory.Create(
                    tIndexElement,
                    obj.Value));
        }
    }
}