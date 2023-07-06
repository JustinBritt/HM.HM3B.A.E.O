namespace HM.HM3B.A.E.O.Classes.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ExpectedValueΦ : IExpectedValueΦ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueΦ(
            RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement>>> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement>> firstInnerTree = this.Value[sIndexElement];

            RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement> secondInnerTree;

            bool result = firstInnerTree.TryGetValue(
                lIndexElement,
                out secondInnerTree);

            if (result)
            {
                return secondInnerTree[ΛIndexElement].Value;
            }
            else
            {
                return 0m;
            }
        }
    }
}