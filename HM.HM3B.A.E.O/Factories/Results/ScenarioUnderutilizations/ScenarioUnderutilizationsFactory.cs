namespace HM.HM3B.A.E.O.Factories.Results.ScenarioUnderutilizations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsFactory : IScenarioUnderutilizationsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsFactory()
        {
        }

        public IScenarioUnderutilizations Create(
            ImmutableList<IScenarioUnderutilizationsResultElement> value)
        {
            IScenarioUnderutilizations result = null;

            try
            {
                result = new ScenarioUnderutilizations(
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