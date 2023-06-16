﻿namespace HM.HM3B.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;

    public interface IdFactory
    {
        Id Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IdIndexElement> value);
    }
}