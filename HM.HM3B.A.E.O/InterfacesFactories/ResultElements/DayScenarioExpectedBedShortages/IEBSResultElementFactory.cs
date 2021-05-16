namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;

    public interface IEBSResultElementFactory
    {
        IEBSResultElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}