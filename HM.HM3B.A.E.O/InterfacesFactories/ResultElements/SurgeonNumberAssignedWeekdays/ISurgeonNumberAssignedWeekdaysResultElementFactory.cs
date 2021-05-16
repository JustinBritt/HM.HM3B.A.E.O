namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;

    public interface ISurgeonNumberAssignedWeekdaysResultElementFactory
    {
        ISurgeonNumberAssignedWeekdaysResultElement Create(
            IsIndexElement sIndexElement,
            int value);
    }
}