namespace HM.HM3B.A.E.O.InterfacesFactories.IndexElements
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IΛIndexElementFactory
    {
        IΛIndexElement Create(
            INullableValue<int> value);
    }
}