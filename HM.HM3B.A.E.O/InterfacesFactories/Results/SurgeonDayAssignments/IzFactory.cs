namespace HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;

    public interface IzFactory
    {
        Iz Create(
            RedBlackTree<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>> value);
    }
}