namespace HM.HM3B.A.E.O.Classes.Results.SurgeonOperatingRoomAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomAssignments;
    
    internal sealed class y : Iy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public y(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> Value { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IyOuterVisitor<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> yOuterVisitor = new HM.HM3B.A.E.O.Visitors.Results.SurgeonOperatingRoomAssignments.yOuterVisitor<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>>(
                nullableValueFactory,
                new HM.HM3B.A.E.O.Classes.Comparers.LocationComparer(),
                new HM.HM3B.A.E.O.Classes.Comparers.OrganizationComparer());

            this.Value.AcceptVisitor(
                yOuterVisitor);

            return yOuterVisitor.RedBlackTree;
        }
    }
}