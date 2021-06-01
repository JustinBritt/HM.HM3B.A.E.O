namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioNumberPatients
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsCalculationFactory : IScenarioNumberPatientsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsCalculationFactory()
        {
        }

        public IScenarioNumberPatientsCalculation Create()
        {
            IScenarioNumberPatientsCalculation calculation = null;

            try
            {
                calculation = new ScenarioNumberPatientsCalculation();
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