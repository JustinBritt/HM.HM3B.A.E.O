namespace HM.HM3B.A.E.O.Factories.ResultElements.ScenarioRecoveryWardServiceLevels
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardServiceLevels;

    internal sealed class υ2ResultElementFactory : Iυ2ResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ2ResultElementFactory()
        {
        }

        public Iυ2ResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            Iυ2ResultElement resultElement = null;

            try
            {
                resultElement = new υ2ResultElement(
                    ΛIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}