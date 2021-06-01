namespace HM.HM3B.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class srjCrossJoinElementFactory : IsrjCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srjCrossJoinElementFactory()
        {
        }

        public IsrjCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IjIndexElement jIndexElement)
        {
            IsrjCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new srjCrossJoinElement(
                    sIndexElement,
                    rIndexElement,
                    jIndexElement);
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