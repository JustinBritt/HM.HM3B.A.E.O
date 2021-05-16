namespace HM.HM3B.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class srtCrossJoinElement : IsrtCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srtCrossJoinElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.tIndexElement = tIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public ItIndexElement tIndexElement { get; }
    }
}