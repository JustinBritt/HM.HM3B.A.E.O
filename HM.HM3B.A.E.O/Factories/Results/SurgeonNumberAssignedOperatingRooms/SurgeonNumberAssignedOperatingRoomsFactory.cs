namespace HM.HM3B.A.E.O.Factories.Results.SurgeonNumberAssignedOperatingRooms
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;

    internal sealed class SurgeonNumberAssignedOperatingRoomsFactory : ISurgeonNumberAssignedOperatingRoomsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRoomsFactory()
        {
        }

        public ISurgeonNumberAssignedOperatingRooms Create(
            ImmutableList<ISurgeonNumberAssignedOperatingRoomsResultElement> value)
        {
            ISurgeonNumberAssignedOperatingRooms result = null;

            try
            {
                result = new SurgeonNumberAssignedOperatingRooms(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}