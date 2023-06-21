namespace HM.HM3B.A.E.O.Classes.Parameters.SurgicalSpecialtyOperatingRoomAssignments
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class w : Iw
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w(
            RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwParameterElement>> Value { get; }

        public int GetElementAtAsint(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement)
        {
            return this.Value[jIndexElement][rIndexElement].Value.Value.Value ? 1 : 0;
        }
    }
}