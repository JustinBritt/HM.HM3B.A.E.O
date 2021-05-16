namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;

    public interface ITEBSResultElementFactory
    {
        ITEBSResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}