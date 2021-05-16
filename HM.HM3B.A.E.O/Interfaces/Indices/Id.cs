namespace HM.HM3B.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface Id
    {
        ImmutableList<IdIndexElement> Value { get; }
    }
}