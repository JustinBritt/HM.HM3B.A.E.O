namespace HM.HM3B.A.E.O.Classes.ResultElements.ScenarioTotalExpectedBedShortages
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;

    internal sealed class TEBSResultElement : ITEBSResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSResultElement(
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