namespace HM.HM3B.A.E.O.Factories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;

    internal sealed class hFactory : IhFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public hFactory()
        {
        }

        public Ih Create(
            ImmutableList<IhParameterElement> value)
        {
            Ih parameter = null;

            try
            {
                parameter = new h(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}