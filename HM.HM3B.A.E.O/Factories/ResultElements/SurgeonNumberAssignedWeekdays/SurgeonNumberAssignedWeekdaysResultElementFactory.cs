namespace HM.HM3B.A.E.O.Factories.ResultElements.SurgeonNumberAssignedWeekdays
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;

    internal sealed class SurgeonNumberAssignedWeekdaysResultElementFactory : ISurgeonNumberAssignedWeekdaysResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedWeekdaysResultElementFactory()
        {
        }

        public ISurgeonNumberAssignedWeekdaysResultElement Create(
            IsIndexElement sIndexElement,
            int value)
        {
            ISurgeonNumberAssignedWeekdaysResultElement resultElement = null;

            try
            {
                resultElement = new SurgeonNumberAssignedWeekdaysResultElement(
                    sIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}