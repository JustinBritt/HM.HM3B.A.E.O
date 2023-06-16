namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonLengthOfStayMaximums
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;

    public interface ILFactory
    {
        IL Create(
            RedBlackTree<IsIndexElement, ILParameterElement> value);
    }
}