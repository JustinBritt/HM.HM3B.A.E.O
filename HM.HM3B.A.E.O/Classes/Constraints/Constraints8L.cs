namespace HM.HM3B.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints8L : IConstraints8L
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8L(
            ImmutableList<IConstraints8LConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints8LConstraintElement> Value { get; }
    }
}