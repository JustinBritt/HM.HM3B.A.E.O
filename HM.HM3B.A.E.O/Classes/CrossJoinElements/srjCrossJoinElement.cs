namespace HM.HM3B.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class srjCrossJoinElement : IsrjCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srjCrossJoinElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IjIndexElement jIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.jIndexElement = jIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public IjIndexElement jIndexElement { get; }
    }
}