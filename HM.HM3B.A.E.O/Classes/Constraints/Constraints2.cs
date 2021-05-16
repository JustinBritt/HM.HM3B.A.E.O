namespace HM.HM3B.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints2 : IConstraints2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints2(
            ImmutableList<IConstraints2ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints2ConstraintElement> Value { get; }
    }
}