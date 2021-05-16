namespace HM.HM3B.A.E.O.Classes.ResultElements.OperatingRoomDayAssignedAvailabilities
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γResultElement : IγResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γResultElement(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            bool value)
        {
            this.rIndexElement = rIndexElement;

            this.tIndexElement = tIndexElement;

            this.Value = value;
        }

        public IrIndexElement rIndexElement { get; }

        public ItIndexElement tIndexElement { get; }

        public bool Value { get; }
    }
}