namespace HM.HM3B.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class sdtCrossJoinElement : IsdtCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sdtCrossJoinElement(
            IsIndexElement sIndexElement,
            IdIndexElement dIndexElement,
            ItIndexElement tIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.dIndexElement = dIndexElement;

            this.tIndexElement = tIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IdIndexElement dIndexElement { get; }

        public ItIndexElement tIndexElement { get; }
    }
}