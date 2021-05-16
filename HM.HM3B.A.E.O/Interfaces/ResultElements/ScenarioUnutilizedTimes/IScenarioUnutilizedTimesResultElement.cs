namespace HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IScenarioUnutilizedTimesResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}