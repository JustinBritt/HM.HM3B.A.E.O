namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioRequiredNumberBeds
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRequiredNumberBeds;

    internal sealed class RNBCalculationFactory : IRNBCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RNBCalculationFactory()
        {
        }

        public IRNBCalculation Create()
        {
            IRNBCalculation calculation = null;

            try
            {
                calculation = new RNBCalculation();
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