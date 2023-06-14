namespace HM.HM3B.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IlIndexElement
    {
        /// <summary>
        /// Gets the day.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}