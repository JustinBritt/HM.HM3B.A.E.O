namespace HM.HM3B.A.E.O.Factories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ExpectedValueΦResultElementFactory : IExpectedValueΦResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueΦResultElementFactory()
        {
        }

        public IExpectedValueΦResultElement Create(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            IExpectedValueΦResultElement resultElement = null;

            try
            {
                resultElement = new ExpectedValueΦResultElement(
                    sIndexElement,
                    lIndexElement,
                    ΛIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}