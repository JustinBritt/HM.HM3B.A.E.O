namespace HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;

    public interface IzFactory
    {
        Iz Create(
            ImmutableList<IzResultElement> value);
    }
}