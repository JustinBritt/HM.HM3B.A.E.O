namespace HM.HM3B.A.E.O.Factories.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedOperatingRooms;

    internal sealed class SurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory : ISurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
        }

        public ISurgeonNumberAssignedOperatingRoomsResultElementCalculation Create()
        {
            ISurgeonNumberAssignedOperatingRoomsResultElementCalculation calculation = null;

            try
            {
                calculation = new SurgeonNumberAssignedOperatingRoomsResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return calculation;
        }
    }
}