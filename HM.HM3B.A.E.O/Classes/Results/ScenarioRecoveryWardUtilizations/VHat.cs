namespace HM.HM3B.A.E.O.Classes.Results.ScenarioRecoveryWardUtilizations
{
    using System.Collections.Immutable;
    using System.Linq;
 
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardUtilizations;

    internal sealed class VHat : IVHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VHat(
            ImmutableList<IVHatResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IVHatResultElement> Value { get; }

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