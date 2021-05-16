namespace HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedWeekdays
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonNumberAssignedWeekdays;

    public interface ISurgeonNumberAssignedWeekdaysFactory
    {
        ISurgeonNumberAssignedWeekdays Create(
            ImmutableList<ISurgeonNumberAssignedWeekdaysResultElement> value);
    }
}