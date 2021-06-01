namespace HM.HM3B.A.E.O.Factories.ResultElements.ScenarioTotalExpectedBedShortages
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;

    internal sealed class TEBSResultElementFactory : ITEBSResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSResultElementFactory()
        {
        }

        public ITEBSResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            ITEBSResultElement resultElement = null;

            try
            {
                resultElement = new TEBSResultElement(
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