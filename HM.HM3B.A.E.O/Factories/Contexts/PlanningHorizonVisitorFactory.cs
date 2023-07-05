namespace HM.HM3B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.IndexElements;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM3B.A.E.O.Visitors.Contexts;

    internal sealed class PlanningHorizonVisitorFactory : IPlanningHorizonVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlanningHorizonVisitorFactory()
        {
        }

        public IPlanningHorizonVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            ItIndexElementFactory tIndexElementFactory,
            IFhirDateTimeComparer FhirDateTimeComparer)
            where TKey : INullableValue<int>
            where TValue : FhirDateTime
        {
            IPlanningHorizonVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new PlanningHorizonVisitor<TKey, TValue>(
                    redBlackTreeFactory,
                    tIndexElementFactory,
                    FhirDateTimeComparer);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}