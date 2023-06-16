namespace HM.HM3B.A.E.O.Classes.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class B : IB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public B(
            RedBlackTree<IjIndexElement, IBParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IjIndexElement, IBParameterElement> Value { get; }

        public int GetElementAtAsint(
            IjIndexElement jIndexElement)
        {
            return this.Value[jIndexElement].Value.Value.Value;
        }
    }
}