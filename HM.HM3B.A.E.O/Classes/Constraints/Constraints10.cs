namespace HM.HM3B.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints10 : IConstraints10
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints10(
            ImmutableList<IConstraints10ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints10ConstraintElement> Value { get; }
    }
}