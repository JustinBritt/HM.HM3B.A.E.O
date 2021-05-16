namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;

    public interface IScenarioTotalTimesResultElementFactory
    {
        IScenarioTotalTimesResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}