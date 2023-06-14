namespace HM.HM3B.A.E.O.Classes.ParameterElements.MachineOperatingRoomAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;

    internal sealed class vParameterElement : IvParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vParameterElement(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            INullableValue<bool> value)
        {
            this.mIndexElement = mIndexElement;

            this.rIndexElement = rIndexElement;

            this.Value = value;
        }

        public ImIndexElement mIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public INullableValue<bool> Value { get; }
    }
}