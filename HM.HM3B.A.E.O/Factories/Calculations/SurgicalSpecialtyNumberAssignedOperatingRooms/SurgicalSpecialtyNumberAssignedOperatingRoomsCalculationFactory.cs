namespace HM.HM3B.A.E.O.Factories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory : ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory()
        {
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculation Create()
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculation calculation = null;

            try
            {
                calculation = new SurgicalSpecialtyNumberAssignedOperatingRoomsCalculation();
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