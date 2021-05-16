namespace HM.HM3B.A.E.O.Factories.Results.DayScenarioExpectedBedShortages
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.DayScenarioExpectedBedShortages;

    internal sealed class EBSFactory : IEBSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSFactory()
        {
        }

        public IEBS Create(
            ImmutableList<IEBSResultElement> value)
        {
            IEBS result = null;

            try
            {
                result = new EBS(
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