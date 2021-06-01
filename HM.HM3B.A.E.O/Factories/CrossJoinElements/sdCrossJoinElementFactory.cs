namespace HM.HM3B.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class sdCrossJoinElementFactory : IsdCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sdCrossJoinElementFactory()
        {
        }

        public IsdCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IdIndexElement dIndexElement)
        {
            IsdCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new sdCrossJoinElement(
                    sIndexElement,
                    dIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoinElement;
        }
    }
}