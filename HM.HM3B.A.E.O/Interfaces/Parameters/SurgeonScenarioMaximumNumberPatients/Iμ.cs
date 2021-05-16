﻿namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    public interface Iμ
    {
        ImmutableList<IμParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement);
    }
}