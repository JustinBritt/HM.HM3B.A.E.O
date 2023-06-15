namespace HM.HM3B.A.E.O.Classes.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class jIndexElement : IjIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jIndexElement(
            Organization value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public Organization Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IrIndexElement other)
        {
            return String.CompareOrdinal(
                other.Value.Id,
                this.Value.Id);
        }
    }
}