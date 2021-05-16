namespace HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.MachineOperatingRoomAssignments
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;

    public interface IvParameterElementFactory
    {
        IvParameterElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            FhirBoolean value);
    }
}