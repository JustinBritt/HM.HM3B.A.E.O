namespace HM.HM3B.A.E.O.Classes.ResultElements.ScenarioRecoveryWardUtilizations
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardUtilizations;

    internal sealed class VHatResultElement : IVHatResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VHatResultElement(
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