namespace HM.HM3B.A.E.O.Interfaces.Parameters.DayAvailabilities
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;

    public interface Iψ
    {
        RedBlackTree<ItIndexElement, IψParameterElement> Value { get; }

        int GetElementAtAsint(
            ItIndexElement tIndexElement);
    }
}