namespace HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IBParameterElement
    {
        IjIndexElement jIndexElement { get; }

        PositiveInt Value { get; }
    }
}