namespace HM.HM3B.A.E.O.Factories.Parameters.SurgicalSpecialtyOperatingRoomAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Parameters.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class wFactory : IwFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wFactory()
        {
        }

        public Iw Create(
            ImmutableList<IwParameterElement> value)
        {
            Iw parameter = null;

            try
            {
                parameter = new w(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}