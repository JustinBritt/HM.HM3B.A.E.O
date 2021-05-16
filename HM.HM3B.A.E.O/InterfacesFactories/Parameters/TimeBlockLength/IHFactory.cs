namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.TimeBlockLength
{
    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Parameters.TimeBlockLength;

    public interface IHFactory
    {
        IH Create(
            Duration value);
    }
}