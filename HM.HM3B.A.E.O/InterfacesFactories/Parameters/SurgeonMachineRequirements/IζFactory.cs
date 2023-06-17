namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonMachineRequirements
{
    using NGenerics.DataStructures.Trees;

    using HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;

    public interface IζFactory
    {
        Iζ Create(
            RedBlackTree<IsIndexElement, RedBlackTree<ImIndexElement, IζParameterElement>> value);
    }
}