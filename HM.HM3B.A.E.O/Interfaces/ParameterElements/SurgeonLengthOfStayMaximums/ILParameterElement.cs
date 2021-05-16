namespace HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface ILParameterElement
    {
        IsIndexElement sIndexElement { get; }

        PositiveInt Value { get; }
    }
}