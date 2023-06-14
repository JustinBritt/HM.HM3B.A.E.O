namespace HM.HM3B.A.E.O.Classes.ParameterElements.SurgeonNumberAssignedTimeBlocks
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;

    internal sealed class BParameterElement : IBParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BParameterElement(
            IsIndexElement sIndexElement,
            INullableValue<int> value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public INullableValue<int> Value { get; }
    }
}