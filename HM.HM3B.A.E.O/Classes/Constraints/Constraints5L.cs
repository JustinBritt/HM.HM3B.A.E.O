namespace HM.HM3B.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints5L : IConstraints5L
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5L(
            ImmutableList<IConstraints5LConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints5LConstraintElement> Value { get; }
    }
}