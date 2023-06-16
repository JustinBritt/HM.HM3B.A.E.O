namespace HM.HM3B.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class d : Interfaces.Indices.Id
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d(
            RedBlackTree<INullableValue<int>, IdIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IdIndexElement> Value { get; }
    }
}