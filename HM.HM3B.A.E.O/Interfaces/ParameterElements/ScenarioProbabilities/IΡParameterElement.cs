namespace HM.HM3B.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IΡParameterElement
    {
        IΛIndexElement ΛIndexElement { get; }

        FhirDecimal Value { get; }
    }
}