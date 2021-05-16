namespace HM.HM3B.A.E.O.Classes.Parameters.TimeBlockLength
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Parameters.TimeBlockLength;

    internal sealed class H : IH
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public H(
            Duration value)
        {
            this.Value = value;
        }

        public Duration Value { get; }
    }
}