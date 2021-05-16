namespace HM.HM3B.A.E.O.Classes.Results.ScenarioRecoveryWardServiceLevels
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;

    internal sealed class υ2 : Iυ2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ2(
            ImmutableList<Iυ2ResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Iυ2ResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IΛIndexElement ΛIndexElement)
        {
            return this.Value
                .Where(x => x.ΛIndexElement == ΛIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }
    }
}