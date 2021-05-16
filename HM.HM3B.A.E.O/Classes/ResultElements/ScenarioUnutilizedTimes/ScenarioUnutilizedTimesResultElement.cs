namespace HM.HM3B.A.E.O.Classes.ResultElements.ScenarioUnutilizedTimes
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;

    internal sealed class ScenarioUnutilizedTimesResultElement : IScenarioUnutilizedTimesResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesResultElement(
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            this.ΛIndexElement = ΛIndexElement;

            this.Value = value;
        }

        public IΛIndexElement ΛIndexElement { get; }

        public decimal Value { get; }
    }
}