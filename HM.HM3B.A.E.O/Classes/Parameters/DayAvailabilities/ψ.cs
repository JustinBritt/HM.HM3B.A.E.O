namespace HM.HM3B.A.E.O.Classes.Parameters.DayAvailabilities
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.DayAvailabilities;

    internal sealed class ψ : Iψ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ψ(
            ImmutableList<IψParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IψParameterElement> Value { get; }

        public int GetElementAtAsint(
            ItIndexElement tIndexElement)
        {
            return this.Value
                .Where(x => x.tIndexElement == tIndexElement)
                .Select(x => x.Value.Value.Value ? 1 : 0)
                .SingleOrDefault();
        }
    }
}