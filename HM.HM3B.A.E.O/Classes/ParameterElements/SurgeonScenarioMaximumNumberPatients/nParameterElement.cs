namespace HM.HM3B.A.E.O.Classes.ParameterElements.SurgeonScenarioMaximumNumberPatients
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    internal sealed class nParameterElement : InParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public nParameterElement(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            PositiveInt value)
        {
            this.sIndexElement = sIndexElement;

            this.ΛIndexElement = ΛIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IΛIndexElement ΛIndexElement { get; }

        public PositiveInt Value { get; }
    }
}