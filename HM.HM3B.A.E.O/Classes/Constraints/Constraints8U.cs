namespace HM.HM3B.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints8U : IConstraints8U
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8U(
            ImmutableList<IConstraints8UConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints8UConstraintElement> Value { get; }
    }
}