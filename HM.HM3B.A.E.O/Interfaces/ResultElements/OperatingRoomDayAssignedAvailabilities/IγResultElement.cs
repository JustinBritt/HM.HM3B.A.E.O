namespace HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IγResultElement
    {
        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }

        bool Value { get; }
    }
}