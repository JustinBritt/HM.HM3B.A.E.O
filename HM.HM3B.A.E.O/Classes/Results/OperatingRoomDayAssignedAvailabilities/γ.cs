namespace HM.HM3B.A.E.O.Classes.Results.OperatingRoomDayAssignedAvailabilities
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Results.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesVisitors.Results.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γ : Iγ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γ(
            RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>> Value { get; }

        public RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IγOuterVisitor<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>> γOuterVisitor = new HM.HM3B.A.E.O.Visitors.Results.OperatingRoomDayAssignedAvailabilities.γOuterVisitor<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>>(
                nullableValueFactory,
                new HM.HM3B.A.E.O.Classes.Comparers.FhirDateTimeComparer(),
                new HM.HM3B.A.E.O.Classes.Comparers.LocationComparer());

            this.Value.AcceptVisitor(
                γOuterVisitor);

            return γOuterVisitor.RedBlackTree;
        }
    }
}