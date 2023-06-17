namespace HM.HM3B.A.E.O.Classes.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;

    internal sealed class n : In
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public n(
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, InParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, InParameterElement>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            return this.Value[sIndexElement][ΛIndexElement].Value.Value.Value;
        }
    }
}