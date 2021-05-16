namespace HM.HM3B.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IdIndexElement
    {
        /// <summary>
        /// Gets the weekday.
        /// </summary>
        PositiveInt Value { get; }
    }
}