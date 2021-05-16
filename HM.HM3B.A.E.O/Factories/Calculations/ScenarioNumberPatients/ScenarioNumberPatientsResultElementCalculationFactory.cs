namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioNumberPatients
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsResultElementCalculationFactory : IScenarioNumberPatientsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsResultElementCalculationFactory()
        {
        }

        public IScenarioNumberPatientsResultElementCalculation Create()
        {
            IScenarioNumberPatientsResultElementCalculation calculation = null;

            try
            {
                calculation = new ScenarioNumberPatientsResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}