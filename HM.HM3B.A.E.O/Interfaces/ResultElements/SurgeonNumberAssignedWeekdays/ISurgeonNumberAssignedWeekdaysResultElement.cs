namespace HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface ISurgeonNumberAssignedWeekdaysResultElement
    {
        IsIndexElement sIndexElement { get; }

        int Value { get; }
    }
}