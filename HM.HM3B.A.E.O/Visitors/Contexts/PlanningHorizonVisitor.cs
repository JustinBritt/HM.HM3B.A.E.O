namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.InterfacesFactories.IndexElements;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class PlanningHorizonVisitor<TKey, TValue> : IPlanningHorizonVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : FhirDateTime
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlanningHorizonVisitor(
            ItIndexElementFactory tIndexElementFactory,
            IFhirDateTimeComparer FhirDateTimeComparer)
        {
            this.tIndexElementFactory = tIndexElementFactory;

            this.RedBlackTree = new RedBlackTree<FhirDateTime, ItIndexElement>(
                FhirDateTimeComparer);
        }

        private ItIndexElementFactory tIndexElementFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<FhirDateTime, ItIndexElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Value,
                this.tIndexElementFactory.Create(
                    obj.Key.Value.Value,
                    obj.Value));
        }
    }
}