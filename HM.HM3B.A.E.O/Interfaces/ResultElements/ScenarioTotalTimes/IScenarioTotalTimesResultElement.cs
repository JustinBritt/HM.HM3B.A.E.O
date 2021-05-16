namespace HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IScenarioTotalTimesResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}