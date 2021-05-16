namespace HM.HM3B.A.E.O.Classes.ResultElements.SurgeonOperatingRoomAssignments
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;

    internal sealed class yResultElement : IyResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yResultElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            bool value)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public bool Value { get; }
    }
}