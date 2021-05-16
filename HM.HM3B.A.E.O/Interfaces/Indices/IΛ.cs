namespace HM.HM3B.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IΛ
    {
        ImmutableList<IΛIndexElement> Value { get; }

        IΛIndexElement GetElementAt(
            PositiveInt value);
    }
}