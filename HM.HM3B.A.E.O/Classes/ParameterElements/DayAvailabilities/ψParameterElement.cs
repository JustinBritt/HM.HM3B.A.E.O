namespace HM.HM3B.A.E.O.Classes.ParameterElements.DayAvailabilities
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;

    internal sealed class ψParameterElement : IψParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ψParameterElement(
            ItIndexElement tIndexElement,
            FhirBoolean value)
        {
            this.tIndexElement = tIndexElement;

            this.Value = value;
        }

        public ItIndexElement tIndexElement { get; }

        public FhirBoolean Value { get; }
    }
}