namespace HM.HM3B.A.E.O.Classes.Results.ScenarioUnderutilizations
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ScenarioUnderutilizations : IScenarioUnderutilizations
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizations(
            ImmutableList<IScenarioUnderutilizationsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IScenarioUnderutilizationsResultElement> Value { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> redBlackTree = new(
                new HM.HM3B.A.E.O.Classes.Comparers.NullableValueintComparer());

            foreach (IScenarioUnderutilizationsResultElement scenarioUnderutilizationsResultElement in this.Value)
            {
                redBlackTree.Add(
                    scenarioUnderutilizationsResultElement.ΛIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        scenarioUnderutilizationsResultElement.Value));
            }

            return redBlackTree;
        }
    }
}