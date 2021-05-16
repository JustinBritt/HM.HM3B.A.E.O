namespace HM.HM3B.A.E.O.Classes.Parameters.ScenarioProbabilities
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;

    internal sealed class Ρ : IΡ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Ρ(
            ImmutableList<IΡParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IΡParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IΛIndexElement ΛIndexElement)
        {
            return this.Value
                .Where(x => x.ΛIndexElement == ΛIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}