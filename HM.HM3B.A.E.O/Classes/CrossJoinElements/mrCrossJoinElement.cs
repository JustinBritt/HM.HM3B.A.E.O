namespace HM.HM3B.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class mrCrossJoinElement : ImrCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mrCrossJoinElement(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement)
        {
            this.mIndexElement = mIndexElement;

            this.rIndexElement = rIndexElement;
        }

        public ImIndexElement mIndexElement { get; }

        public IrIndexElement rIndexElement { get; }
    }
}