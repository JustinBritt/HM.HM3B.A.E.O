namespace HM.HM3B.A.E.O.Classes.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class β : Iβ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public β(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>>> Value { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IβOuterVisitor<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>>> βOuterVisitor = new HM.HM3B.A.E.O.Visitors.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks.βOuterVisitor<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>>>(
                nullableValueFactory,
                new HM.HM3B.A.E.O.Classes.Comparers.LocationComparer(),
                new HM.HM3B.A.E.O.Classes.Comparers.NullableValueintComparer(),
                new HM.HM3B.A.E.O.Classes.Comparers.OrganizationComparer());

            this.Value.AcceptVisitor(
                βOuterVisitor);

            return βOuterVisitor.RedBlackTree;
        }
    }
}