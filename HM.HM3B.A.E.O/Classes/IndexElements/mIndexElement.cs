namespace HM.HM3B.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class mIndexElement : ImIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mIndexElement(
            Device value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public Device Value { get; }
    }
}