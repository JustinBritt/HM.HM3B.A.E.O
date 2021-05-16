namespace HM.HM3B.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class slCrossJoinElement : IslCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public slCrossJoinElement(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.lIndexElement = lIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IlIndexElement lIndexElement { get; }
    }
}