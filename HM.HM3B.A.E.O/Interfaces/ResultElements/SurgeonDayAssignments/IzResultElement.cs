namespace HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IzResultElement
    {
        IsIndexElement sIndexElement { get; }

        ItIndexElement tIndexElement { get; }

        bool Value { get; }
    }
}