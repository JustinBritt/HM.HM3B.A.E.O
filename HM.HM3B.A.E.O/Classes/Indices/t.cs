namespace HM.HM3B.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;

    internal sealed class t : It
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public t(
            RedBlackTree<FhirDateTime, ItIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<FhirDateTime, ItIndexElement> Value { get; }

        public ItIndexElement GetElementAt(
            int value)
        {
            return this.Value.Values
                .Where(x => x.Key == value)
                .SingleOrDefault();
        }

        public ItIndexElement GetElementAt(
            FhirDateTime value)
        {
            return this.Value[value];
        }

        public ImmutableList<ItIndexElement> GetNthElementsAt(
            int startKey,
            int endKey,
            int N)
        {
            ImmutableList<ItIndexElement>.Builder builder = ImmutableList.CreateBuilder<ItIndexElement>();

            // max i: this.t.Value.Distinct().Count() - (int)this.W.Value.Value + (int)dIndexElement.Value.Value
            for (int i = startKey; i <= endKey; i = i + N)
            {
                builder.Add(
                    this.GetElementAt(
                        i));
            }

            return builder.ToImmutableList();
        }

        public int GetT()
        {
            return this.Value.Values
                .Select(x => x.Key)
                .Max();
        }
    }
}