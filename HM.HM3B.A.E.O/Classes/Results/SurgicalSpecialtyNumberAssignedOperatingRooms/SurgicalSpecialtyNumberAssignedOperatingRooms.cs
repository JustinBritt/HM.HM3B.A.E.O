namespace HM.HM3B.A.E.O.Classes.Results.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRooms : ISurgicalSpecialtyNumberAssignedOperatingRooms
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRooms(
            ImmutableList<ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new(
                new HM.HM3B.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement surgicalSpecialtyNumberAssignedOperatingRoomsResultElement in this.Value)
            {
                redBlackTree.Add(
                    surgicalSpecialtyNumberAssignedOperatingRoomsResultElement.jIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        surgicalSpecialtyNumberAssignedOperatingRoomsResultElement.Value));
            }
            return redBlackTree;
        }
    }
}