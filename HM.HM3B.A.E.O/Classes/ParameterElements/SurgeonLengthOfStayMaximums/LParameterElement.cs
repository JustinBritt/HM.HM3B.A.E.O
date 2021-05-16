namespace HM.HM3B.A.E.O.Classes.ParameterElements.SurgeonLengthOfStayMaximums
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;

    internal sealed class LParameterElement : ILParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LParameterElement(
            IsIndexElement sIndexElement,
            PositiveInt value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public PositiveInt Value { get; }
    }
}