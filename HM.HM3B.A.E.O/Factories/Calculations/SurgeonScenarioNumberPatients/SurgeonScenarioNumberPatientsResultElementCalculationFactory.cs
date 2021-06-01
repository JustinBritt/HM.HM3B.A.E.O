namespace HM.HM3B.A.E.O.Factories.Calculations.SurgeonScenarioNumberPatients
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsResultElementCalculationFactory : ISurgeonScenarioNumberPatientsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsResultElementCalculationFactory()
        {
        }

        public ISurgeonScenarioNumberPatientsResultElementCalculation Create()
        {
            ISurgeonScenarioNumberPatientsResultElementCalculation calculation = null;

            try
            {
                calculation = new SurgeonScenarioNumberPatientsResultElementCalculation();
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