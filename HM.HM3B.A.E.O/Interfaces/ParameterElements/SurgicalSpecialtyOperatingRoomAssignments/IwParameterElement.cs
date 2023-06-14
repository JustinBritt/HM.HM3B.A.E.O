namespace HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IwParameterElement
    {
        IjIndexElement jIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        INullableValue<bool> Value { get; }
    }
}