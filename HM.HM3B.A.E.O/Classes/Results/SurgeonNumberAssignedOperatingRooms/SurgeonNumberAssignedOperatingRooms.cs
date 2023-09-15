namespace HM.HM3B.A.E.O.Classes.Results.SurgeonNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonNumberAssignedOperatingRooms : ISurgeonNumberAssignedOperatingRooms
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRooms(
            ImmutableList<ISurgeonNumberAssignedOperatingRoomsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonNumberAssignedOperatingRoomsResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new(
                new HM.HM3B.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (ISurgeonNumberAssignedOperatingRoomsResultElement surgeonNumberAssignedOperatingRoomsResultElement in this.Value)
            {
                redBlackTree.Add(
                    surgeonNumberAssignedOperatingRoomsResultElement.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                    surgeonNumberAssignedOperatingRoomsResultElement.Value));
            }

            return redBlackTree;
        }
    }
}