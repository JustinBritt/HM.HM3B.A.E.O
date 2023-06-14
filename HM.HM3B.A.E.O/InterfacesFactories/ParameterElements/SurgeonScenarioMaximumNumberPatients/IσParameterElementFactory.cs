namespace HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    public interface IσParameterElementFactory
    {
        IσParameterElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            INullableValue<decimal> value);
    }
}