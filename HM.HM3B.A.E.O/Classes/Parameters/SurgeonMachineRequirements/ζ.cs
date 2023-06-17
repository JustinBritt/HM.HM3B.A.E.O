namespace HM.HM3B.A.E.O.Classes.Parameters.SurgeonMachineRequirements
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;

    internal sealed class ζ : Iζ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ζ(
            RedBlackTree<IsIndexElement, RedBlackTree<ImIndexElement, IζParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<ImIndexElement, IζParameterElement>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ImIndexElement mIndexElement)
        {
            return this.Value[sIndexElement][mIndexElement].Value.Value.Value ? 1 : 0;
        }
    }
}