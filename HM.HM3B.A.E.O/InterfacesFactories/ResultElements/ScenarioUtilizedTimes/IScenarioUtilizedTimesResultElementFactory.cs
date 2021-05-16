namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;

    public interface IScenarioUtilizedTimesResultElementFactory
    {
        IScenarioUtilizedTimesResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}