namespace HM.HM3B.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class d : Interfaces.Indices.Id
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d(
            ImmutableList<IdIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IdIndexElement> Value { get; }
    }
}