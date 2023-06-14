namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.MaximumNumberRecoveryWardBeds
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;

    public interface IΩFactory
    {
        IΩ Create(
            INullableValue<int> value);
    }
}