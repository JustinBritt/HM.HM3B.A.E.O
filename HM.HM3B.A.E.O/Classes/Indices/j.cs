namespace HM.HM3B.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;

    internal sealed class j : Ij
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public j(
            RedBlackTree<Organization, IjIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<Organization, IjIndexElement> Value { get; }

        public IjIndexElement GetElementAt(
            Organization value)
        {
            return this.Value[value];
        }
    }
}