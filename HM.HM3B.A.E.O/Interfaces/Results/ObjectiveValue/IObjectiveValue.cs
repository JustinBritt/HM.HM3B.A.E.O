namespace HM.HM3B.A.E.O.Interfaces.Results.ObjectiveValue
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IObjectiveValue
    {
        decimal Value { get; }

        INullableValue<decimal> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}