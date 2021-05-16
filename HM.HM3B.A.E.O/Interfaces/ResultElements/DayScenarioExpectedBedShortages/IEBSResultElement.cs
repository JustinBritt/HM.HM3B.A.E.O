namespace HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IEBSResultElement
    {
        ItIndexElement tIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}