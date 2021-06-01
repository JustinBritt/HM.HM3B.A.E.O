namespace HM.HM3B.A.E.O.Factories.Results.OperatingRoomDayAssignedAvailabilities
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Results.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γFactory : IγFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γFactory()
        {
        }

        public Iγ Create(
            ImmutableList<IγResultElement> value)
        {
            Iγ result = null;

            try
            {
                result = new γ(
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