namespace HM.HM3B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory
    {
        ISurgicalSpecialtyNumberAssignedTimeBlocksVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IBParameterElementFactory BParameterElementFactory,
            Ij j)
            where TKey : Organization
            where TValue : INullableValue<int>;
    }
}