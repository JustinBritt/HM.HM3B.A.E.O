namespace HM.HM3B.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class mrCrossJoinElementFactory : ImrCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mrCrossJoinElementFactory()
        {
        }

        public ImrCrossJoinElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement)
        {
            ImrCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new mrCrossJoinElement(
                    mIndexElement,
                    rIndexElement);
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