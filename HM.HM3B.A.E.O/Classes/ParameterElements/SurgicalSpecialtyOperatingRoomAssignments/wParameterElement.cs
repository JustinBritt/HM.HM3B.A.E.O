namespace HM.HM3B.A.E.O.Classes.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class wParameterElement : IwParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wParameterElement(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            FhirBoolean value)
        {
            this.jIndexElement = jIndexElement;

            this.rIndexElement = rIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public FhirBoolean Value { get; }
    }
}