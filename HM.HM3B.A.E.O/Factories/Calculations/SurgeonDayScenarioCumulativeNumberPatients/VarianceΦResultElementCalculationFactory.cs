namespace HM.HM3B.A.E.O.Factories.Calculations.SurgeonDayScenarioCumulativeNumberPatients
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class VarianceΦResultElementCalculationFactory : IVarianceΦResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceΦResultElementCalculationFactory()
        {
        }

        public IVarianceΦResultElementCalculation Create()
        {
            IVarianceΦResultElementCalculation calculation = null;

            try
            {
                calculation = new VarianceΦResultElementCalculation();
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