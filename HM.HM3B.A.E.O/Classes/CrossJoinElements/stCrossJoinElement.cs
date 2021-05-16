namespace HM.HM3B.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class stCrossJoinElement : IstCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public stCrossJoinElement(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.tIndexElement = tIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public ItIndexElement tIndexElement { get; }
    }
}