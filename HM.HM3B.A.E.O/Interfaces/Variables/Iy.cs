namespace HM.HM3B.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;

    public interface Iy
    {
        VariableCollection<IsIndexElement, IrIndexElement> Value { get; }

        bool GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement);

        Interfaces.Results.SurgeonOperatingRoomAssignments.Iy GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IyResultElementFactory yResultElementFactory,
            IyFactory yFactory,
            Ir r,
            Is s);
    }
}