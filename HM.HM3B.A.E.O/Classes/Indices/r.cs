namespace HM.HM3B.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;

    internal sealed class r : Ir
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public r(
            RedBlackTree<Location, IrIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<Location, IrIndexElement> Value { get; }

        public IrIndexElement GetElementAt(
            Location value)
        {
            return this.Value[value];
        }
    }
}