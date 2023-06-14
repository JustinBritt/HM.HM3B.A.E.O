namespace HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IσParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        INullableValue<decimal> Value { get; }
    }
}