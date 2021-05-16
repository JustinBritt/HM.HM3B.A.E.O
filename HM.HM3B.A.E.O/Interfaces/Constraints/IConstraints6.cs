namespace HM.HM3B.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints6
    {
        ImmutableList<IConstraints6ConstraintElement> Value { get; }
    }
}