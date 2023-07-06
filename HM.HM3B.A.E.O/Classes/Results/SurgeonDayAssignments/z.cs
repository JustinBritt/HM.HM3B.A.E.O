namespace HM.HM3B.A.E.O.Classes.Results.SurgeonDayAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonDayAssignments;

    internal sealed class z : Iz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public z(
            RedBlackTree<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value[sIndexElement][tIndexElement].Value ? 1 : 0;
        }

        public RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IzOuterVisitor<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>> xOuterVisitor = new HM.HM3B.A.E.O.Visitors.Results.SurgeonDayAssignments.zOuterVisitor<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>>(
                nullableValueFactory,
                new HM.HM3B.A.E.O.Classes.Comparers.FhirDateTimeComparer(),
                new HM.HM3B.A.E.O.Classes.Comparers.OrganizationComparer());

            this.Value.AcceptVisitor(
                xOuterVisitor);

            return xOuterVisitor.RedBlackTree;
        }
    }
}