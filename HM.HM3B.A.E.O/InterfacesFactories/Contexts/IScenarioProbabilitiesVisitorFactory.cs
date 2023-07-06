namespace HM.HM3B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    public interface IScenarioProbabilitiesVisitorFactory
    {
        IScenarioProbabilitiesVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IΡParameterElementFactory ΡParameterElementFactory,
            IΛ Λ)
            where TKey : INullableValue<int>
            where TValue : INullableValue<decimal>;
    }
}