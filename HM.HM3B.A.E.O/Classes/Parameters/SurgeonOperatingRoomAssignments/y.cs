namespace HM.HM3B.A.E.O.Classes.Parameters.SurgeonOperatingRoomAssignments
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;

    internal sealed class y : Iy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public y(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyParameterElement>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement)
        {
            return this.Value[sIndexElement][rIndexElement].Value.Value.Value ? 1 : 0;
        }
    }
}