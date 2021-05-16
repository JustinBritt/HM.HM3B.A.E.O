namespace HM.HM3B.A.E.O.Factories.Parameters.SurgeonOperatingRoomAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomAssignments;

    internal sealed class yFactory : IyFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yFactory()
        {
        }

        public Iy Create(
            ImmutableList<IyParameterElement> value)
        {
            Iy parameter = null;

            try
            {
                parameter = new y(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}