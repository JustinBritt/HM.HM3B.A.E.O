namespace HM.HM3B.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;

    public interface Ix
    {
        VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> Value { get; }

        bool GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement);

        Interfaces.Results.SurgeonOperatingRoomDayAssignments.Ix GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IxResultElementFactory xResultElementFactory,
            IxFactory xFactory,
            Ir r,
            Is s,
            It t);
    }
}