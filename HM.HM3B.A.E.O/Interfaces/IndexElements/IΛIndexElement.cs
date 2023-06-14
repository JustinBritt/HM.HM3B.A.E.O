namespace HM.HM3B.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IΛIndexElement
    {
        /// <summary>
        /// Gets the scenario.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}