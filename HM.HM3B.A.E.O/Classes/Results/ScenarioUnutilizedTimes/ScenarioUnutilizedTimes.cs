namespace HM.HM3B.A.E.O.Classes.Results.ScenarioUnutilizedTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ScenarioUnutilizedTimes : IScenarioUnutilizedTimes
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimes(
            ImmutableList<IScenarioUnutilizedTimesResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IScenarioUnutilizedTimesResultElement> Value { get; }

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

            foreach (IScenarioUnutilizedTimesResultElement scenarioUnutilizedTimesResultElement in this.Value)
            {
                redBlackTree.Add(
                    scenarioUnutilizedTimesResultElement.ΛIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        scenarioUnutilizedTimesResultElement.Value));
            }

            return redBlackTree;
        }
    }
}