namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.DayAvailabilities
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.DayAvailabilities;

    public interface IψFactory
    {
        Iψ Create(
            RedBlackTree<ItIndexElement, IψParameterElement> value);
    }
}