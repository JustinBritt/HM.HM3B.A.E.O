namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;

    public interface IWFactory
    {
        IW Create(
            INullableValue<int> value);
    }
}