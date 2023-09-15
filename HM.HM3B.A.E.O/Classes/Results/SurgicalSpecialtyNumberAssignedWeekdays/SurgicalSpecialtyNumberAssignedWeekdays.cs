namespace HM.HM3B.A.E.O.Classes.Results.SurgicalSpecialtyNumberAssignedWeekdays
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgicalSpecialtyNumberAssignedWeekdays : ISurgicalSpecialtyNumberAssignedWeekdays
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedWeekdays(
            ImmutableList<ISurgicalSpecialtyNumberAssignedWeekdaysResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgicalSpecialtyNumberAssignedWeekdaysResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new(
                new HM.HM3B.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (ISurgicalSpecialtyNumberAssignedWeekdaysResultElement surgicalSpecialtyNumberAssignedWeekdaysResultElement in this.Value)
            {
                redBlackTree.Add(
                    surgicalSpecialtyNumberAssignedWeekdaysResultElement.jIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        surgicalSpecialtyNumberAssignedWeekdaysResultElement.Value));
            }

            return redBlackTree;
        }
    }
}