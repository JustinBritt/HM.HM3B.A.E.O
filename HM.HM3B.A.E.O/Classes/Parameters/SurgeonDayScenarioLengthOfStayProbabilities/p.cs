namespace HM.HM3B.A.E.O.Classes.Parameters.SurgeonDayScenarioLengthOfStayProbabilities
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;

    internal sealed class p : Ip
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public p(
            RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IpParameterElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IpParameterElement>>> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            return this.Value[sIndexElement][lIndexElement][ΛIndexElement].Value.Value.Value;
        }
    }
}