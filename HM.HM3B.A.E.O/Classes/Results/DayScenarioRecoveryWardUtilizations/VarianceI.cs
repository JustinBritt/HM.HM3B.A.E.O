namespace HM.HM3B.A.E.O.Classes.Results.DayScenarioRecoveryWardUtilizations
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class VarianceI : IVarianceI
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceI(
            ImmutableList<IVarianceIResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IVarianceIResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            return this.Value
                .Where(x => x.tIndexElement == tIndexElement && x.ΛIndexElement == ΛIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            It t,
            IΛ Λ)
        {
            RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> outerRedBlackTree = new(
                new HM.HM3B.A.E.O.Classes.Comparers.FhirDateTimeComparer());

            foreach (ItIndexElement tIndexElement in t.Value.Values)
            {
                RedBlackTree<INullableValue<int>, INullableValue<decimal>> innerRedBlackTree = new(
                    new HM.HM3B.A.E.O.Classes.Comparers.NullableValueintComparer());

                foreach (IΛIndexElement ΛIndexElement in Λ.Value.Values)
                {
                    innerRedBlackTree.Add(
                        ΛIndexElement.Value,
                        nullableValueFactory.Create<decimal>(
                            this.GetElementAtAsdecimal(
                                tIndexElement,
                                ΛIndexElement)));
                }    
            }

            return outerRedBlackTree;
        }
    }
}