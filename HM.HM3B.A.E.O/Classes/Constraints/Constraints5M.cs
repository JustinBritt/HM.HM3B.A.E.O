namespace HM.HM3B.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints5M : IConstraints5M
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5M(
            ImmutableList<IConstraints5MConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints5MConstraintElement> Value { get; }
    }
}