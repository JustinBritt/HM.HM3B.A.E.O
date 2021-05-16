namespace HM.HM3B.A.E.O.Classes.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;

    internal sealed class hParameterElement : IhParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public hParameterElement(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            Duration value)
        {
            this.sIndexElement = sIndexElement;

            this.ΛIndexElement = ΛIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IΛIndexElement ΛIndexElement { get; }

        public Duration Value { get; }
    }
}