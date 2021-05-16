namespace HM.HM3B.A.E.O.Classes.ResultElements.ScenarioUtilizedTimes
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;

    internal sealed class ScenarioUtilizedTimesResultElement : IScenarioUtilizedTimesResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUtilizedTimesResultElement(
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