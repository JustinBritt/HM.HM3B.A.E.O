namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments;

    public interface IwFactory
    {
        Iw Create(
            RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwParameterElement>> value);
    }
}