namespace HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;

    public interface IyFactory
    {
        Iy Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> value);
    }
}