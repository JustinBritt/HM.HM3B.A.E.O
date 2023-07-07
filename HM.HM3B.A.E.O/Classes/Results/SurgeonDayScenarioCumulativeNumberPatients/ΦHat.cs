namespace HM.HM3B.A.E.O.Classes.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ΦHat : IΦHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΦHat(
            RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatResultElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatResultElement>>> Value { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IΦHatOuterVisitor<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatResultElement>>> xOuterVisitor = new HM.HM3B.A.E.O.Visitors.Results.SurgeonDayScenarioCumulativeNumberPatients.ΦHatOuterVisitor<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatResultElement>>>(
                nullableValueFactory,
                new HM.HM3B.A.E.O.Classes.Comparers.NullableValueintComparer(),
                new HM.HM3B.A.E.O.Classes.Comparers.OrganizationComparer());

            this.Value.AcceptVisitor(
                xOuterVisitor);

            return xOuterVisitor.RedBlackTree;
        }
    }
}