namespace HM.HM3B.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class sdCrossJoinElement : IsdCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sdCrossJoinElement(
            IsIndexElement sIndexElement,
            IdIndexElement dIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.dIndexElement = dIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IdIndexElement dIndexElement { get; }
    }
}