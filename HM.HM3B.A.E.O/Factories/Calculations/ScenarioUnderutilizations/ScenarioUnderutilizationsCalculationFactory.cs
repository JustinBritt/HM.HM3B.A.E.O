namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioUnderutilizations
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsCalculationFactory : IScenarioUnderutilizationsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsCalculationFactory()
        {
        }

        public IScenarioUnderutilizationsCalculation Create()
        {
            IScenarioUnderutilizationsCalculation calculation = null;

            try
            {
                calculation = new ScenarioUnderutilizationsCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}