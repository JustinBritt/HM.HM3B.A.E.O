namespace HM.HM3B.A.E.O.Classes.ResultElements.SurgeonDayAssignments
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;

    internal sealed class zResultElement : IzResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public zResultElement(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            bool value)
        {
            this.sIndexElement = sIndexElement;

            this.tIndexElement = tIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public ItIndexElement tIndexElement { get; }

        public bool Value { get; }
    }
}