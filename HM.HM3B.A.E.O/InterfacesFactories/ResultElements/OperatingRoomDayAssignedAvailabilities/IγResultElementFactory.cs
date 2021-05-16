namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayAssignedAvailabilities
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;

    public interface IγResultElementFactory
    {
        IγResultElement Create(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            bool value);
    }
}