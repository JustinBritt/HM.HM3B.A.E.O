namespace HM.HM3B.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface ImIndexElement : IComparable<ImIndexElement>
    {
        /// <summary>
        /// Gets the machine.
        /// </summary>
        Device Value { get; }
    }
}