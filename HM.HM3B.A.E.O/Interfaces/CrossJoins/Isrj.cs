﻿namespace HM.HM3B.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;

    public interface Isrj
    {
        ImmutableList<IsrjCrossJoinElement> Value { get; }
    }
}