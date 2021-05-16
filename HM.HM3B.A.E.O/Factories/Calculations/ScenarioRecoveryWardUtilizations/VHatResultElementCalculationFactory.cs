namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioRecoveryWardUtilizations
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRecoveryWardUtilizations;

    internal sealed class VHatResultElementCalculationFactory : IVHatResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VHatResultElementCalculationFactory()
        {
        }

        public IVHatResultElementCalculation Create()
        {
            IVHatResultElementCalculation calculation = null;

            try
            {
                calculation = new VHatResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}