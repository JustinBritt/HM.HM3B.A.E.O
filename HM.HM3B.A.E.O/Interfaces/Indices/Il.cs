namespace HM.HM3B.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface Il
    {
        ImmutableList<IlIndexElement> Value { get; }

        IlIndexElement GetElementAt(
            int day);

        IlIndexElement GetElementAt(
            INullableValue<int> day);
    }
}