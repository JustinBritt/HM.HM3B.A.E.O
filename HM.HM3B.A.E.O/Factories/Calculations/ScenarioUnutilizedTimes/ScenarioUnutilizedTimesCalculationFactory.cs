namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioUnutilizedTimes
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioUnutilizedTimes;

    internal sealed class ScenarioUnutilizedTimesCalculationFactory : IScenarioUnutilizedTimesCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesCalculationFactory()
        {
        }

        public IScenarioUnutilizedTimesCalculation Create()
        {
            IScenarioUnutilizedTimesCalculation calculation = null;

            try
            {
                calculation = new ScenarioUnutilizedTimesCalculation();
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