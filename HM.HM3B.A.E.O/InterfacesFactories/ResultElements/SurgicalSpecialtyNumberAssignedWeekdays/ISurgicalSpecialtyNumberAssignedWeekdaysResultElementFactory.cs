namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory
    {
        ISurgicalSpecialtyNumberAssignedWeekdaysResultElement Create(
            IjIndexElement jIndexElement,
            int value);
    }
}