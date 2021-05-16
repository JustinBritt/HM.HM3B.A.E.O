namespace HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface ISurgicalSpecialtyNumberAssignedWeekdaysResultElement
    {
        IjIndexElement jIndexElement { get; }

        int Value { get; }
    }
}