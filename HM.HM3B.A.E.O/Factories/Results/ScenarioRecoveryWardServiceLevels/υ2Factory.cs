namespace HM.HM3B.A.E.O.Factories.Results.ScenarioRecoveryWardServiceLevels
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardServiceLevels;

    internal sealed class υ2Factory : Iυ2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ2Factory()
        {
        }

        public Iυ2 Create(
            ImmutableList<Iυ2ResultElement> value)
        {
            Iυ2 result = null;

            try
            {
                result = new υ2(
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