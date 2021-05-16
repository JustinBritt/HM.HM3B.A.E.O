namespace HM.HM3B.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints10
    {
        ImmutableList<IConstraints10ConstraintElement> Value { get; }
    }
}