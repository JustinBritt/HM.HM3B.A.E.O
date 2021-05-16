namespace HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;

    public interface IwParameterElementFactory
    {
        IwParameterElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            FhirBoolean value);
    }
}