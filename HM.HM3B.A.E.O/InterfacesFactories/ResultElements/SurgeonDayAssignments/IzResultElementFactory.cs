namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;

    public interface IzResultElementFactory
    {
        IzResultElement Create(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            bool value);
    }
}