namespace HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;

    public interface IpParameterElementFactory
    {
        IpParameterElement Create(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement,
            INullableValue<decimal> value);
    }
}