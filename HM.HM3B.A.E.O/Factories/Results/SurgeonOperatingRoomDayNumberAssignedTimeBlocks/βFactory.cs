namespace HM.HM3B.A.E.O.Factories.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class βFactory : IβFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βFactory()
        {
        }

        public Iβ Create(
            ImmutableList<IβResultElement> value)
        {
            Iβ result = null;

            try
            {
                result = new β(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}