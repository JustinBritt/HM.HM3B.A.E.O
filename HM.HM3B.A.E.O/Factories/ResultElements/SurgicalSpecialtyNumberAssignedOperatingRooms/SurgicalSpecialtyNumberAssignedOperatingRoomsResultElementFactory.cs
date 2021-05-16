namespace HM.HM3B.A.E.O.Factories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory : ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory()
        {
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement Create(
            IjIndexElement jIndexElement,
            int value)
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement resultElement = null;

            try
            {
                resultElement = new SurgicalSpecialtyNumberAssignedOperatingRoomsResultElement(
                    jIndexElement,
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