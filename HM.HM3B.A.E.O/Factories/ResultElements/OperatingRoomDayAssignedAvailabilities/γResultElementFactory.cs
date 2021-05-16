namespace HM.HM3B.A.E.O.Factories.ResultElements.OperatingRoomDayAssignedAvailabilities
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γResultElementFactory : IγResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γResultElementFactory()
        {
        }

        public IγResultElement Create(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            bool value)
        {
            IγResultElement resultElement = null;

            try
            {
                resultElement = new γResultElement(
                    rIndexElement,
                    tIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}