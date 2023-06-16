namespace HM.HM3B.A.E.O.Classes.Parameters.SurgeonNumberAssignedTimeBlocks
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;

    internal sealed class B : IB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public B(
            RedBlackTree<IsIndexElement, IBParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, IBParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement)
        {
            return this.Value[sIndexElement].Value.Value.Value;
        }
    }
}