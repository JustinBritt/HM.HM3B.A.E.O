namespace HM.HM3B.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class tΛCrossJoinElementFactory : ItΛCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public tΛCrossJoinElementFactory()
        {
        }

        public ItΛCrossJoinElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            ItΛCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new tΛCrossJoinElement(
                    tIndexElement,
                    ΛIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoinElement;
        }
    }
}