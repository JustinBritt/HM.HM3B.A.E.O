namespace HM.HM3B.A.E.O.Factories.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;

    internal sealed class xResultElementFactory : IxResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xResultElementFactory()
        {
        }

        public IxResultElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            bool value)
        {
            IxResultElement resultElement = null;

            try
            {
                resultElement = new xResultElement(
                    sIndexElement,
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