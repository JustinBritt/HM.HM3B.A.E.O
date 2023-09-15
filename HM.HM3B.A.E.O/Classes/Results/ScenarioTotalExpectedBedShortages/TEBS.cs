namespace HM.HM3B.A.E.O.Classes.Results.ScenarioTotalExpectedBedShortages
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class TEBS : ITEBS
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBS(
            ImmutableList<ITEBSResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ITEBSResultElement> Value { get; }

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

            foreach (ITEBSResultElement TEBSResultElement in this.Value)
            {
                redBlackTree.Add(
                    TEBSResultElement.ΛIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        TEBSResultElement.Value));
            }

            return redBlackTree;
        }
    }
}