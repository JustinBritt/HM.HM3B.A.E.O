namespace HM.HM3B.A.E.O.InterfacesFactories.Contexts
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgicalSpecialtiesVisitorFactory
    {
        ISurgicalSpecialtiesVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IΔParameterElementFactory ΔParameterElementFactory,
            Ij j,
            Is s)
            where TKey : Organization
            where TValue : IImmutableSet<Organization>;
    }
}