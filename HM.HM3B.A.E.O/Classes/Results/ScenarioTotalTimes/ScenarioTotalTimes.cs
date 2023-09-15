namespace HM.HM3B.A.E.O.Classes.Results.ScenarioTotalTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ScenarioTotalTimes : IScenarioTotalTimes
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimes(
            ImmutableList<IScenarioTotalTimesResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IScenarioTotalTimesResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IΛIndexElement ΛIndexElement)
        {
            return this.Value
                .Where(x => x.ΛIndexElement == ΛIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> redBlackTree = new(
                new HM.HM3B.A.E.O.Classes.Comparers.NullableValueintComparer());

            foreach (IScenarioTotalTimesResultElement scenarioTotalTimesResultElement in this.Value)
            {
                redBlackTree.Add(
                    scenarioTotalTimesResultElement.ΛIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        scenarioTotalTimesResultElement.Value));
            }

            return redBlackTree;
        }
    }
}