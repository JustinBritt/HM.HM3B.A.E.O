namespace HM.HM3B.A.E.O.Classes.Results.ScenarioNumberPatients
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ScenarioNumberPatients : IScenarioNumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatients(
            ImmutableList<IScenarioNumberPatientsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IScenarioNumberPatientsResultElement> Value { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<INullableValue<int>, INullableValue<int>> redBlackTree = new(
                new HM.HM3B.A.E.O.Classes.Comparers.NullableValueintComparer());

            foreach (IScenarioNumberPatientsResultElement scenarioNumberPatientsResultElement in this.Value)
            {
                redBlackTree.Add(
                    scenarioNumberPatientsResultElement.ΛIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        scenarioNumberPatientsResultElement.Value));
            }

            return redBlackTree;
        }
    }
}