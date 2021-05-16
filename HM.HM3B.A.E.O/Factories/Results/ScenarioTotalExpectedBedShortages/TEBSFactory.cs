namespace HM.HM3B.A.E.O.Factories.Results.ScenarioTotalExpectedBedShortages
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioTotalExpectedBedShortages;

    internal sealed class TEBSFactory : ITEBSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSFactory()
        {
        }

        public ITEBS Create(
            ImmutableList<ITEBSResultElement> value)
        {
            ITEBS result = null;

            try
            {
                result = new TEBS(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}