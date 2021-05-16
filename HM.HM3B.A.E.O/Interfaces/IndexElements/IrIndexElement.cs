namespace HM.HM3B.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IrIndexElement
    {
        /// <summary>
        /// Gets the operating room.
        /// </summary>
        Location Value { get; }
    }
}