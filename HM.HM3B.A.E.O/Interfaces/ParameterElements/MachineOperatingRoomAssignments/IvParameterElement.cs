namespace HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IvParameterElement
    {
        ImIndexElement mIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        FhirBoolean Value { get; }
    }
}