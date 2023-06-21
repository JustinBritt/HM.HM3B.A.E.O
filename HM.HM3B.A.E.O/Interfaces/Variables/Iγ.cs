namespace HM.HM3B.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.OperatingRoomDayAssignedAvailabilities;

    public interface Iγ
    {
        VariableCollection<IrIndexElement, ItIndexElement> Value { get; }

        bool GetElementAt(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement);

        Interfaces.Results.OperatingRoomDayAssignedAvailabilities.Iγ GetElementsAt(
            IγResultElementFactory γResultElementFactory,
            IγFactory γFactory,
            Ir r,
            It t);
    }
}