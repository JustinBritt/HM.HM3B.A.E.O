namespace HM.HM3B.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;

    internal sealed class s : Is
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public s(
            RedBlackTree<Organization, IsIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<Organization, IsIndexElement> Value { get; }

        public IsIndexElement GetElementAt(
            Organization value)
        {
            return this.Value[value];
        }
    }
}