namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioRequiredNumberBeds
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRequiredNumberBeds;

    internal sealed class MRNBCalculationFactory : IMRNBCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MRNBCalculationFactory()
        {
        }

        public IMRNBCalculation Create()
        {
            IMRNBCalculation calculation = null;

            try
            {
                calculation = new MRNBCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}