namespace HM.HM3B.A.E.O.Factories.Results.ScenarioNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsFactory : IScenarioNumberPatientsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsFactory()
        {
        }

        public IScenarioNumberPatients Create(
            ImmutableList<IScenarioNumberPatientsResultElement> value)
        {
            IScenarioNumberPatients result = null;

            try
            {
                result = new ScenarioNumberPatients(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}