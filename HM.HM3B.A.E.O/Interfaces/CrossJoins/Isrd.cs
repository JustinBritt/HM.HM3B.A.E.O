namespace HM.HM3B.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;

    public interface Isrd
    {
        ImmutableList<IsrdCrossJoinElement> Value { get; }
    }
}