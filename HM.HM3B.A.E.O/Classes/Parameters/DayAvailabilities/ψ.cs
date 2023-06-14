namespace HM.HM3B.A.E.O.Classes.Parameters.DayAvailabilities
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.DayAvailabilities;

    internal sealed class ψ : Iψ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ψ(
            RedBlackTree<ItIndexElement, IψParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<ItIndexElement, IψParameterElement> Value { get; }

        public int GetElementAtAsint(
            ItIndexElement tIndexElement)
        {
            return this.Value[tIndexElement].Value.Value.Value ? 1 : 0;
        }
    }
}