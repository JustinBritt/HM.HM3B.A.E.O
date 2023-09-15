namespace HM.HM3B.A.E.O.Interfaces.Results.ScenarioUtilizedTimes
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IScenarioUtilizedTimes
    {
        ImmutableList<IScenarioUtilizedTimesResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IΛIndexElement ΛIndexElement);

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}