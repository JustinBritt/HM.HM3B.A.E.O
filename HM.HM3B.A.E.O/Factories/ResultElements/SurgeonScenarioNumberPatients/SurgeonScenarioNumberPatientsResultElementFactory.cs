namespace HM.HM3B.A.E.O.Factories.ResultElements.SurgeonScenarioNumberPatients
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsResultElementFactory : ISurgeonScenarioNumberPatientsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsResultElementFactory()
        {
        }

        public ISurgeonScenarioNumberPatientsResultElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            int value)
        {
            ISurgeonScenarioNumberPatientsResultElement resultElement = null;

            try
            {
                resultElement = new SurgeonScenarioNumberPatientsResultElement(
                    sIndexElement,
                    ΛIndexElement,
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