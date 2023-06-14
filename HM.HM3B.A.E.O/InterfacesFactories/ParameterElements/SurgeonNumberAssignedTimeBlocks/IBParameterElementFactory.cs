namespace HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;

    public interface IBParameterElementFactory
    {
        IBParameterElement Create(
            IsIndexElement sIndexElement,
            INullableValue<int> value);
    }
}