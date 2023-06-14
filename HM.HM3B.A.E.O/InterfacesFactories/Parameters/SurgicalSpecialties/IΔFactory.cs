namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;

    public interface IΔFactory
    {
        IΔ Create(
            RedBlackTree<IjIndexElement, ImmutableList<IsIndexElement>> redBlackTree,
            ImmutableList<IΔParameterElement> value);
    }
}