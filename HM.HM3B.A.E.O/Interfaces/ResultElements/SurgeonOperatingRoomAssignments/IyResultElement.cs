namespace HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IyResultElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        bool Value { get; }
    }
}