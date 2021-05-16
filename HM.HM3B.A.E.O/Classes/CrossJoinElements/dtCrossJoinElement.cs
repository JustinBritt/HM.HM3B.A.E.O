namespace HM.HM3B.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class dtCrossJoinElement : IdtCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dtCrossJoinElement(
            IdIndexElement dIndexElement,
            ItIndexElement tIndexElement)
        {
            this.dIndexElement = dIndexElement;

            this.tIndexElement = tIndexElement;
        }

        public IdIndexElement dIndexElement { get; }

        public ItIndexElement tIndexElement { get; }
    }
}