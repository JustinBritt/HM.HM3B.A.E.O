namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;

    public interface IΡFactory
    {
        IΡ Create(
            RedBlackTree<IΛIndexElement, IΡParameterElement> value);
    }
}