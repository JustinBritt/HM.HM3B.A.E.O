namespace HM.HM3B.A.E.O.Factories.Calculations.ScenarioRecoveryWardUtilizations
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRecoveryWardUtilizations;

    internal sealed class VHatCalculationFactory : IVHatCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VHatCalculationFactory()
        {
        }

        public IVHatCalculation Create()
        {
            IVHatCalculation calculation = null;

            try
            {
                calculation = new VHatCalculation();
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