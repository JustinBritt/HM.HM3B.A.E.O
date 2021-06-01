namespace HM.HM3B.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements; 
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class srdCrossJoinElementFactory : IsrdCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srdCrossJoinElementFactory()
        {
        }

        public IsrdCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement)
        {
            IsrdCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new srdCrossJoinElement(
                    sIndexElement,
                    rIndexElement,
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