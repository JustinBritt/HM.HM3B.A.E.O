namespace HM.HM3B.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class stCrossJoinElementFactory : IstCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public stCrossJoinElementFactory()
        {
        }

        public IstCrossJoinElement Create(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement)
        {
            IstCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new stCrossJoinElement(
                    sIndexElement,
                    tIndexElement);
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