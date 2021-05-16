namespace HM.HM3B.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class tΛCrossJoinElement : ItΛCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public tΛCrossJoinElement(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            this.tIndexElement = tIndexElement;

            this.ΛIndexElement = ΛIndexElement;
        }

        public ItIndexElement tIndexElement { get; }

        public IΛIndexElement ΛIndexElement { get; }
    }
}