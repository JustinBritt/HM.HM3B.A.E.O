namespace HM.HM3B.A.E.O.Classes.Parameters.MachineOperatingRoomAssignments
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MachineOperatingRoomAssignments;

    internal sealed class v : Iv
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public v(
            RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvParameterElement>> Value { get; }

        public int GetElementAtAsint(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement)
        {
            return this.Value[mIndexElement][rIndexElement].Value.Value.Value ? 1 : 0;
        }
    }
}