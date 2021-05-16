namespace HM.HM3B.A.E.O.Classes.ResultElements.ScenarioNumberPatients
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsResultElement : IScenarioNumberPatientsResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsResultElement(
            IΛIndexElement ΛIndexElement,
            int value)
        {
            this.ΛIndexElement = ΛIndexElement;

            this.Value = value;
        }

        public IΛIndexElement ΛIndexElement { get; }

        public int Value { get; }
    }
}