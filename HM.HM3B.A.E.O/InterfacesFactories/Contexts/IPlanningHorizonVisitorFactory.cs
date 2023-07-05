namespace HM.HM3B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.IndexElements;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    public interface IPlanningHorizonVisitorFactory
    {
        IPlanningHorizonVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            ItIndexElementFactory tIndexElementFactory,
            IFhirDateTimeComparer FhirDateTimeComparer)
            where TKey : INullableValue<int>
            where TValue : FhirDateTime;
    }
}