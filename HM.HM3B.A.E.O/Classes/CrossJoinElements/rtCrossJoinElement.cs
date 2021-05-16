namespace HM.HM3B.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class rtCrossJoinElement : IrtCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rtCrossJoinElement(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            this.rIndexElement = rIndexElement;

            this.tIndexElement = tIndexElement;
        }

        public IrIndexElement rIndexElement { get; }

        public ItIndexElement tIndexElement { get; }
    }
}