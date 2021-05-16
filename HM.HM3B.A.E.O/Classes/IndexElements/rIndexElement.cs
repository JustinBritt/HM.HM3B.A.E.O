namespace HM.HM3B.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class rIndexElement : IrIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rIndexElement(
            Location value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the operating room.
        /// </summary>
        public Location Value { get; }
    }
}