namespace HM.HM3B.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints8U
    {
        ImmutableList<IConstraints8UConstraintElement> Value { get; }
    }
}