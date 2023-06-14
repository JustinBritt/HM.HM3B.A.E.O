namespace HM.HM3B.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;

    internal sealed class Λ : IΛ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Λ(
            RedBlackTree<INullableValue<int>, IΛIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IΛIndexElement> Value { get; }

        public IΛIndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }
    }
}